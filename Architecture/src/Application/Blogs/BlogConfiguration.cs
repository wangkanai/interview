// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Interview.Portal.Extensions;

namespace Wangkanai.Interview.Portal.Blogs;

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