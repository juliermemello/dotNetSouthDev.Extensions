namespace dotNetSouthDev.Extensions.Conversions;

public static partial class Conversions
{
    public static TOut ConvertTo<TIn, TOut>(this TIn value) where TIn : struct, IConvertible
    {
        return (TOut)Convert.ChangeType(value, typeof(TOut));
    }
}
