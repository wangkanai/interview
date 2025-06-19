// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Wangkanai.Interview.AppHost.Hosting;

public class HealthCheckAnnotation(Func<IResource, CancellationToken, Task<IHealthCheck?>> healthCheckFactory) : IResourceAnnotation
{
	public Func<IResource, CancellationToken, Task<IHealthCheck?>> HealthCheckFactory { get; } = healthCheckFactory;

	public static HealthCheckAnnotation Create(Func<string, IHealthCheck> connectionStringFactory)
	{
		return new(async (resource, token) => {
			if (resource is not IResourceWithConnectionString c)
				return null;

			return await c.GetConnectionStringAsync(token) is not { } cs
				       ? null
				       : connectionStringFactory(cs);
		});
	}
}
