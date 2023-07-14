namespace dotNetSouthDev.Extensions.Math;

public static partial class MathExtensions
{
    public static double Pow(this double leftSide, double rightSide)
    {
        double result = System.Math.Pow(leftSide, rightSide);
        return result;
    }
}
