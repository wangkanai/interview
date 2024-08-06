// Copyright (c) 2024 Mula-X, All Rights Reserved.

using System.Diagnostics.CodeAnalysis;

using Microsoft.EntityFrameworkCore;

using Npgsql.EntityFrameworkCore.PostgreSQL;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;

namespace Wangkanai.Interview.Portal.Migration.Extensions;

public static class EntityFrameworkServiceCollectionExtensions
{
   public static IServiceCollection AddDbContextPool<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicProperties)] TContext>(
      this IServiceCollection services,
      IHostApplicationBuilder builder,
      string                  name)
      where TContext : DbContext
      => services.AddDbContextPool<TContext>(options =>
      {
         options.UseNpgsql(builder.Configuration.GetConnectionString(name), Context);
      });

   private static void Context(NpgsqlDbContextOptionsBuilder sqlOptions)
      => sqlOptions.ExecutionStrategy(execution => new NpgsqlRetryingExecutionStrategy(execution));
}