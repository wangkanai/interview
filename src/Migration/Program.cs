// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using Wangkanai.Interview;
using Wangkanai.Interview.Migration;
using Wangkanai.Interview.Migration.Extensions;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<MigrationWorker<ApplicationDbContext>>();

builder.AddServiceDefaults();

builder.Services.AddOpenTelemetry()
       .WithTracing(options => options.AddSource(MigrationWorker<ApplicationDbContext>.ActivitySourceName));

builder.Services.AddDbContextPool<ApplicationDbContext>(builder, "portal");
builder.EnrichNpgsqlDbContext<ApplicationDbContext>(EnrichDbContext.Settings);

var host = builder.Build();
host.Run();
