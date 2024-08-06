// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wangkanai.Interview.Portal.Blogs;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
   public void Configure(EntityTypeBuilder<Blog> builder)
   {
      builder.Property(b => b.Title)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(b => b.Content)
             .HasMaxLength(500)
             .IsRequired();

      builder.Property(b => b.CreatedBy)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(b => b.UpdatedBy)
             .HasMaxLength(100);

      builder.Property(b => b.Created)
             .HasDefaultValueSql("NOW()")
             .ValueGeneratedOnAdd();

      builder.Property(b => b.Updated)
             .HasDefaultValueSql("NOW()")
             .ValueGeneratedOnAddOrUpdate();
   }
}