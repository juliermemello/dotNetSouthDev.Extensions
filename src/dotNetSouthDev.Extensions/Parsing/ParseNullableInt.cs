namespace dotNetSouthDev.Extensions.Parsing;

public static partial class ParsingExtensions
{
    public static int? ParseNullableInt(this string input)
    {
        if (!int.TryParse(input, out var result))
        {
            return null;
        }

        return result;
    }
}
