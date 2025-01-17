﻿using Humanizer;

namespace Blogger.Domain.ArticleAggregate;

public sealed class ArticleId : ValueObject<ArticleId>
{
    public required string Slug { get; init; }

    public override IEnumerable<object> GetEqualityComponenets()
    {
        yield return Slug;
    }
  
    public static ArticleId CreateUniqueId(string title) 
        => new ArticleId { Slug = title.Kebaberize() };

    public static ArticleId Create(string value) 
        => new ArticleId{  Slug = value };

    public override string ToString() => Slug;
}
