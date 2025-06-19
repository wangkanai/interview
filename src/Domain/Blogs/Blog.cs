// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved. Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Interview.Blogs;

public sealed class Blog : UserAuditableEntity<int>
{
   public string     Title   { get; set; }
   public List<Post> Posts   { get; set; } = new();
}
