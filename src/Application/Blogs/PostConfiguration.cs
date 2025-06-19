// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Interview.Extensions;

namespace Wangkanai.Interview.Blogs;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
   public void Configure(EntityTypeBuilder<Post> builder)
   {
      builder.HasIndex(post => post.Title)
             .IsUnique();
      
      builder.Property(post => post.Title)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(post => post.Content)
             .HasMaxLength(500)
             .IsRequired();

      builder.Property(post => post.CreatedBy)
             .HasMaxLength(100)
             .IsRequired();

      builder.Property(post => post.UpdatedBy)
             .HasMaxLength(100);

      builder.Property(post => post.Created)
             .NpgValueGeneratedOnAdd();

      builder.Property(post => post.Updated)
             .NpgValueGeneratedOnAddOrUpdate();
      
      builder.HasOne(post => post.Blog)
             .WithMany(blog => blog.Posts)
             .HasForeignKey(post => post.Id)
             .IsRequired()
             .OnDelete(DeleteBehavior.Cascade);
   }
}