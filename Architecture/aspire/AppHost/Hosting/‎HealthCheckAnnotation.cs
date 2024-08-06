// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Wangkanai.Interview.AppHost.Hosting;

public class HealthCheckAnnotation(Func<IResource, CancellationToken, Task<IHealthCheck?>> healthCheckFactory) : IResourceAnnotation
{
   public Func<IResource, CancellationToken, Task<IHealthCheck?>> HealthCheckFactory { get; } = healthCheckFactory;

   public static HealthCheckAnnotation Create(Func<string, IHealthCheck> connectionStringFactory)
   {
      return new(async (resource, token) =>
      {
         if (resource is not IResourceWithConnectionString c)
         {
            return null;
         }

         if (await c.GetConnectionStringAsync(token) is not string cs)
         {
            return null;
         }

         return connectionStringFactory(cs);
      });
   }
}