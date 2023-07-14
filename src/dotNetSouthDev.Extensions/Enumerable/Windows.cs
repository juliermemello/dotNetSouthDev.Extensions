using Ardalis.GuardClauses;

namespace dotNetSouthDev.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
    public static IEnumerable<T[]> Windows<T>(this IEnumerable<T> source, int size)
    {
        Guard.Against.Null(source, nameof(source));
        Guard.Against.NegativeOrZero(size, nameof(size));

        var enumerator = source.GetEnumerator();

        Queue<T> window = new(size + 1);

        while (enumerator.MoveNext())
        {
            window.Enqueue(enumerator.Current);
            if (window.Count > size) window.Dequeue();
            if (window.Count == size) yield return window.ToArray();
        }
    }
}
