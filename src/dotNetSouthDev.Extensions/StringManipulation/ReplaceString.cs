using System.Text.RegularExpressions;

namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static string ReplaceString(this string text, string oldString, string newString, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Count can not be negative");
        }
        else if (oldString is null)
        {
            throw new ArgumentException(nameof(oldString), "OldString can not be null");
        }
        else if (newString is null)
        {
            throw new ArgumentException(nameof(newString), "NewString can not be null");
        }

        Regex regex = new Regex(Regex.Escape(oldString));

        return regex.Replace(text, newString, count);
    }
}
