// Copyright (c) 2024 Mula-X, All Rights Reserved.

using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

using OpenTelemetry.Trace;

namespace Wangkanai.Interview.Migration;

internal class MigrationWorker<T>(IServiceProvider services, IHostApplicationLifetime host)
   : BackgroundService
   where T : DbContext
{
   public const string ActivitySourceName = "Migration";

   private readonly ActivitySource _activitySource = new(ActivitySourceName);

   protected override async Task ExecuteAsync(CancellationToken stoppingToken)
   {
      using var activity = _activitySource.StartActivity("Migrating database", ActivityKind.Client);

      try
      {
         using var scope   = services.CreateScope();
         var       context = scope.ServiceProvider.GetRequiredService<T>();

         await EnsureDatabaseAsync(context, stoppingToken);
         await RunMigrationAsync(context, stoppingToken);
      }
      catch (Exception ex)
      {
         activity?.RecordException(ex);
         throw;
      }
   }

   private static async Task EnsureDatabaseAsync(T context, CancellationToken cancellationToken)
   {
      var dbCreator = context.GetService<IRelationalDatabaseCreator>();

      var strategy = context.Database.CreateExecutionStrategy();
      await strategy.ExecuteAsync(async () =>
      {
         // Create the database if it does not exist.
         // Do this first, so there is then a database to start a transaction against.
         if (!await dbCreator.ExistsAsync(cancellationToken))
            await dbCreator.CreateAsync(cancellationToken);
      });
   }

   private static async Task RunMigrationAsync(T context, CancellationToken cancellationToken)
   {
      var strategy = context.Database.CreateExecutionStrategy();
      await strategy.ExecuteAsync(async () =>
      {
         await using var transaction = await context.Database.BeginTransactionAsync(cancellationToken);
         await context.Database.MigrateAsync(cancellationToken);
         await transaction.CommitAsync(cancellationToken);
      });
   }
}
