// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Interview.Portal.Extensions;

namespace Wangkanai.Interview.Portal.Blogs;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
   public void Configure(EntityTypeBuilder<Blog> builder)
   {
      builder.Property(b => b.Title)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(b => b.CreatedBy)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(b => b.UpdatedBy)
             .HasMaxLength(100);

      builder.Property(b => b.Created)
             .NpgValueGeneratedOnAdd();

      builder.Property(b => b.Updated)
             .NpgValueGeneratedOnAddOrUpdate();
   }
}