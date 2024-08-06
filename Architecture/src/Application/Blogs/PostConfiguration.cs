// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Interview.Portal.Extensions;

namespace Wangkanai.Interview.Portal.Blogs;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
   public void Configure(EntityTypeBuilder<Post> builder)
   {
      builder.Property(p => p.Title)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(p => p.Content)
             .HasMaxLength(500)
             .IsRequired();

      builder.Property(p => p.CreatedBy)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(p => p.UpdatedBy)
             .HasMaxLength(100);

      builder.Property(p => p.Created)
             .NpgValueGeneratedOnAdd();

      builder.Property(p => p.Updated)
             .NpgValueGeneratedOnAddOrUpdate();
   }
}