using System.Text.Json;

namespace dotNetSouthDev.Extensions.Serialization.Json;

public static partial class JsonExtensions
{
    public static string ToJson<T>(this T t)
    {
        var value = JsonSerializer.Serialize(t);

        return value;
    }
}
