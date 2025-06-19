// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Aspire.Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Wangkanai.Interview.Migration.Extensions;

public static class EnrichDbContext
{
   public static void Settings(NpgsqlEntityFrameworkCorePostgreSQLSettings settings)
      => settings.DisableRetry = true;
}