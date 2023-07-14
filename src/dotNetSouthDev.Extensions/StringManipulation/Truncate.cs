namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static string Truncate(this string input, int length)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length), "Length must be >= 0");

        int maxLength = System.Math.Min(input.Length, length);

        return input.Substring(0, maxLength);
    }
}
