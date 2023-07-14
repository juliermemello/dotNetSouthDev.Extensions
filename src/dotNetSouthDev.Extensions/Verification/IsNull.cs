namespace dotNetSouthDev.Extensions.Verification;

public static partial class VerificationExtensions
{
    public static bool IsNull(this object value) =>
         (value == null) ? true : false;
}
