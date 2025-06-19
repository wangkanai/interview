// Copyright (c) 2024 Mula-X, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Interview.Portal.Blogs;

public sealed class Post : UserAuditableEntity<int>
{
   public Blog   Blog    { get; set; }
   public string Title   { get; set; }
   public string Content { get; set; }
}