using Wangkanai.Interview.Portal;
using Wangkanai.Interview.Portal.Migration;
using Wangkanai.Interview.Portal.Migration.Extensions;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<MigrationWorker<ApplicationDbContext>>();

builder.AddServiceDefaults();

builder.Services.AddOpenTelemetry()
       .WithTracing(options => options.AddSource(MigrationWorker<ApplicationDbContext>.ActivitySourceName));

builder.Services.AddDbContextPool<ApplicationDbContext>(builder, "portal");
builder.EnrichNpgsqlDbContext<ApplicationDbContext>(EnrichDbContext.Settings);

var host = builder.Build();
host.Run();