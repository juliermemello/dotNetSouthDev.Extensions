using Ardalis.GuardClauses;

namespace dotNetSouthDev.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        Guard.Against.Null(source, nameof(source));
        Guard.Against.Null(action, nameof(action));

        foreach (var item in source)
        {
            action(item);
        }
    }

    public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action)
    {
        Guard.Against.Null(source, nameof(source));
        Guard.Against.Null(action, nameof(action));

        int index = 0;

        foreach (var item in source)
        {
            action(item, index++);
        }
    }
}
