namespace dotNetSouthDev.Extensions.Parsing;

public static partial class ParsingExtensions
{
    public static bool TryParseInt(this string input, out int result)
    {
        return int.TryParse(input, out result);
    }
}
