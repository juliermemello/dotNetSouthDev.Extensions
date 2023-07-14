using Ardalis.GuardClauses;

namespace dotNetSouthDev.Extensions.Linq;

public static partial class LinqExtensions
{
    public static IEnumerable<T> Perform<T>(this IEnumerable<T> input, Func<T, T> func)
    {
        Guard.Against.Null(input, nameof(input));
        Guard.Against.Null(func, nameof(func));

        foreach (var item in input)
        {
            yield return func(item);
        }
    }
}
