// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wangkanai.Interview.Extensions;

internal static class PostgresConfigurationExtensions
{
   public static void NpgValueGeneratedOnAdd<TProperty>(this PropertyBuilder<TProperty> builder)
   {
      builder.HasDefaultValueSql("NOW()");
      builder.ValueGeneratedOnAdd();
   }

   public static void NpgValueGeneratedOnAddOrUpdate<TProperty>(this PropertyBuilder<TProperty> builder)
   {
      builder.HasDefaultValueSql("NOW()");
      builder.ValueGeneratedOnAddOrUpdate();
   }
}