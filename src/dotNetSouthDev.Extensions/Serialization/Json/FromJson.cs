using System.Text.Json;

namespace dotNetSouthDev.Extensions.Serialization.Json;

public static partial class JsonExtensions
{
    public static T FromJson<T>(this string t)
    {
        T value = JsonSerializer.Deserialize<T>(t);

        return (T)Convert.ChangeType(value, typeof(T));
    }
}
