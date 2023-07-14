namespace dotNetSouthDev.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
    public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
}
