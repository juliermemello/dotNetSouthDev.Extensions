namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static string Right(this string input, int length)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        if (input.Length <= length)
            return input;

        return input.Substring(input.Length - length);
    }
}
