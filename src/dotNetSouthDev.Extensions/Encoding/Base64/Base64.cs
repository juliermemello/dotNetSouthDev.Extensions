using System.Text.RegularExpressions;

namespace dotNetSouthDev.Extensions.Encoding.Base64;

public static partial class Base64
{
    public static string FromBase64(this string encodedString, System.Text.Encoding encoding = null)
    {
        if (string.IsNullOrEmpty(encodedString))
            return string.Empty;

        encodedString = encodedString.Trim();

        var isValidBase64 = (encodedString.Length % 4 == 0) && Regex.IsMatch(encodedString, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        if (!isValidBase64)
            throw new ArgumentException($"{encodedString} is not valid base64");

        var data = Convert.FromBase64String(encodedString);

        encoding = encoding ?? System.Text.Encoding.Default;

        return encoding.GetString(data);
    }

    public static string ToBase64(this string @string, System.Text.Encoding encoding = null)
    {
        if (string.IsNullOrWhiteSpace(@string))
            return string.Empty;

        encoding ??= System.Text.Encoding.Default;

        var stringBytes = encoding.GetBytes(@string);

        return Convert.ToBase64String(stringBytes);
    }
}
