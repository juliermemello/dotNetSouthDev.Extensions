using Ardalis.GuardClauses;

namespace dotNetSouthDev.Extensions.Linq;

public static partial class LinqExtensions
{
    public static IEnumerable<TSource> ConcatMany<TSource>(this IEnumerable<TSource> baseIterator, params IEnumerable<TSource>[] iterators)
    {
        Guard.Against.Null(baseIterator, nameof(baseIterator));
        Guard.Against.Null(iterators, nameof(iterators));

        var combined = iterators.Aggregate(
            (IEnumerable<TSource> acc, IEnumerable<TSource> curr) => acc.Concat(curr));

        return baseIterator.Concat(combined);
    }
}
