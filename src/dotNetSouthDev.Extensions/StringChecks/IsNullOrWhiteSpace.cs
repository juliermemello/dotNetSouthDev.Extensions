namespace dotNetSouthDev.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
    public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
}
