// Copyright (c) 2024 Mula-X, All Rights Reserved.

using HealthChecks.NpgSql;

using Wangkanai.Interview.AppHost.Hosting;

namespace Wangkanai.Interview.AppHost.Extensions;

public static class PostgreSqlHealthCheckExtensions
{
   /// <summary>
   /// Adds a health check to the PostgreSQL server resource.
   /// </summary>
   public static IResourceBuilder<PostgresServerResource> WithHealthCheck(this IResourceBuilder<PostgresServerResource> builder)
   {
      return builder.WithAnnotation(HealthCheckAnnotation.Create(cs => new NpgSqlHealthCheck(new NpgSqlHealthCheckOptions(cs))));
   }

   /// <summary>
   /// Adds a health check to the PostgreSQL database resource.
   /// </summary>
   public static IResourceBuilder<PostgresDatabaseResource> WithHealthCheck(this IResourceBuilder<PostgresDatabaseResource> builder)
   {
      return builder.WithAnnotation(HealthCheckAnnotation.Create(cs => new NpgSqlHealthCheck(new NpgSqlHealthCheckOptions(cs))));
   }
}