namespace dotNetSouthDev.Extensions.Math;

public static partial class MathExtensions
{
    public static int DivideBy(this short dividend, short divisor) => dividend / divisor;

    public static int DivideBy(this short dividend, int divisor) => dividend / divisor;

    public static long DivideBy(this short dividend, long divisor) => dividend / divisor;

    public static int DivideBy(this int dividend, short divisor) => dividend / divisor;

    public static int DivideBy(this int dividend, int divisor) => dividend / divisor;

    public static long DivideBy(this int dividend, long divisor) => dividend / divisor;

    public static long DivideBy(this long dividend, short divisor) => dividend / divisor;

    public static long DivideBy(this long dividend, int divisor) => dividend / divisor;

    public static long DivideBy(this long dividend, long divisor) => dividend / divisor;
}
