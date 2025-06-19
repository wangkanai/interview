// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Interview.Extensions;

namespace Wangkanai.Interview.Blogs;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
   public void Configure(EntityTypeBuilder<Blog> builder)
   {
      builder.HasIndex(blog => blog.Title)
             .IsUnique();

      builder.Property(blog => blog.Title)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(blog => blog.CreatedBy)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(blog => blog.UpdatedBy)
             .HasMaxLength(100);

      builder.Property(blog => blog.Created)
             .NpgValueGeneratedOnAdd();

      builder.Property(blog => blog.Updated)
             .NpgValueGeneratedOnAddOrUpdate();
   }
}