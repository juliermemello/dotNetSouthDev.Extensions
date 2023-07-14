namespace dotNetSouthDev.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
    public static bool IsNull(this string value) => value is null;
}
