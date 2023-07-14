using System.Text;

namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static string SwapCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        var result = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                result.Append(char.ToLower(text[i]));
            }
            else if (char.IsLower(text[i]))
            {
                result.Append(char.ToUpper(text[i]));
            }
            else
            {
                result.Append(text[i]);
            }
        }

        return result.ToString();
    }
}
