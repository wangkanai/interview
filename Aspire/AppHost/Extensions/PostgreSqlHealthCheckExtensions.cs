// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using HealthChecks.NpgSql;

using HealthCheckAnnotation = Wangkanai.Interview.AppHost.Hosting.HealthCheckAnnotation;

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
