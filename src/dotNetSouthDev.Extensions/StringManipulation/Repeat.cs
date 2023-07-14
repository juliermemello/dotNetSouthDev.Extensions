namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static string Repeat(this string text, uint n)
    {
        var textAsSpan = text.AsSpan();
        var span = new Span<char>(new char[textAsSpan.Length * (int)n]);

        for (var i = 0; i < n; i++)
        {
            textAsSpan.CopyTo(span.Slice((int)i * textAsSpan.Length, textAsSpan.Length));
        }

        return span.ToString();
    }
}
