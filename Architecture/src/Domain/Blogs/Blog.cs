// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Interview.Portal.Blogs;

public sealed class Blog : UserAuditableEntity<int>
{
   public string     Title   { get; set; }
   public string     Content { get; set; }
   public List<Post> Posts   { get; set; } = new();
}