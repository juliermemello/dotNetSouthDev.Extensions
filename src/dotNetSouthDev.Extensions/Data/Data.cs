using System.Transactions;

namespace dotNetSouthDev.Extensions.Data;

public static partial class Data
{
    public static List<T> ToListReadUncommitted<T>(this IQueryable<T> query)
    {
        using (var scope = new TransactionScope(
            TransactionScopeOption.Required,
            new TransactionOptions()
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
        {
            List<T> toReturn = query.ToList();
            scope.Complete();
            return toReturn;
        }
    }

    public static int CountReadUncommitted<T>(this IQueryable<T> query)
    {
        using (var scope = new TransactionScope(
            TransactionScopeOption.Required,
            new TransactionOptions()
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
        {
            int toReturn = query.Count();
            scope.Complete();
            return toReturn;
        }
    }
}
