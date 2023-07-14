namespace dotNetSouthDev.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
    public static bool IsAny<T>(this IEnumerable<T> input) =>
        input != null && input.Any();
}
