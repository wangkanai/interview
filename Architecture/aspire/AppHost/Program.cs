using Wangkanai.Interview.AppHost.Constants;
using Wangkanai.Interview.AppHost.Extensions;

var builder = DistributedApplication.CreateBuilder(args);

var seq = builder.AddSeq(ResourceConstants.Seq, 51000).WithDataVolume();

var sqlPassword = builder.CreateStablePassword(ResourceConstants.SqlPassword);
var sqlPgSql = builder.AddPostgres(ResourceConstants.SqlPgSql, null, sqlPassword, 62000)
                      .WithEnvironment(ResourceConstants.SqlPgSql, ResourceConstants.SqlPgSql)
                      .WithDataVolume();

var dbPortal = sqlPgSql.AddDatabase(SchemaConstants.Portal);

builder.AddProject<Projects.Wangkanai_Interview_Portal_Migration>(MigrationConstants.Portal)
       .WithReference(dbPortal)
       .WithReference(seq);

builder.AddProject<Projects.Wangkanai_Interview_Portal>(ResourceConstants.WebPortal)
       .WithReference(dbPortal)
       .WithReference(seq)
       .WithExternalHttpEndpoints();

builder.Build().Run();