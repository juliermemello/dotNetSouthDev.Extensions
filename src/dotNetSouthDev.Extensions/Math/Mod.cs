namespace dotNetSouthDev.Extensions.Math;

public static partial class MathExtensions
{
    public static int Mod(this short leftSide, short rightSide) => leftSide % rightSide;

    public static int Mod(this short leftSide, int rightSide) => leftSide % rightSide;

    public static long Mod(this short leftSide, long rightSide) => leftSide % rightSide;

    public static int Mod(this int leftSide, short rightSide) => leftSide % rightSide;

    public static int Mod(this int leftSide, int rightSide) => leftSide % rightSide;

    public static long Mod(this int leftSide, long rightSide) => leftSide % rightSide;

    public static long Mod(this long leftSide, short rightSide) => leftSide % rightSide;

    public static long Mod(this long leftSide, int rightSide) => leftSide % rightSide;

    public static long Mod(this long leftSide, long rightSide) => leftSide % rightSide;
}
