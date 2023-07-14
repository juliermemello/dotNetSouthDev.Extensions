using System.Text;

namespace dotNetSouthDev.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
    public static string ToCsv<T>(this IEnumerable<T> input)
    {
        if (input == null)
            return string.Empty;

        StringBuilder csvBuilder = new StringBuilder();

        input.ForEach(i => csvBuilder.Append($"{i},"));

        return csvBuilder.ToString(0, csvBuilder.Length - 1);
    }
}
