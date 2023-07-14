using Ardalis.GuardClauses;

namespace dotNetSouthDev.Extensions.List;

public static class ListExtensions
{
    public static void AddIfNotNull<T>(this IList<T> obj, T item)
    {
        Guard.Against.Null(obj, nameof(obj));

        if (item == null) return;

        obj.Add(item);
    }

    public static void AddRangeIfNotNull<T>(this IList<T> obj, IEnumerable<T> items)
    {
        Guard.Against.Null(obj, nameof(obj));

        if (items == null) return;

        if (obj is List<T> objList)
        {
            objList.AddRange(items);

            return;
        }

        foreach (var item in items)
        {
            obj.Add(item);
        }
    }
}
