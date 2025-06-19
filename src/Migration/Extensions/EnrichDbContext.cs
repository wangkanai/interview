// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using Aspire.Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Wangkanai.Interview.Migration.Extensions;

public static class EnrichDbContext
{
   public static void Settings(NpgsqlEntityFrameworkCorePostgreSQLSettings settings)
      => settings.DisableRetry = true;
}