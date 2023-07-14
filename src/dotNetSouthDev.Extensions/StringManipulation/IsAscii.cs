namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static bool IsAscii(this string text)
    {
        return text.ToCharArray().All(c => IsAscii(c));
    }

    private static bool IsAscii(char c) => (uint)c <= '\x007F';
}
