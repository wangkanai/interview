// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wangkanai.Interview.Portal.Extensions;

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