using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace ISKI.Core.Persistence.Dynamic;

public static class DynamicQueryExtensions
{
    public static IQueryable<T> ApplyDynamicQuery<T>(this IQueryable<T> query, DynamicQuery? dynamicQuery)
    {
        if (dynamicQuery == null) return query;

        if (dynamicQuery.Filters != null && dynamicQuery.Filters.Any())
        {
            var whereBuilder = new StringBuilder();
            var parameters = new List<object>();

            for (int i = 0; i < dynamicQuery.Filters.Count; i++)
            {
                var filter = dynamicQuery.Filters[i];
                if (i > 0) whereBuilder.Append(" AND ");

                switch (filter.Operator.ToLower())
                {
                    case "eq":
                        whereBuilder.Append($"{filter.Field} == @{i}");
                        parameters.Add(filter.Value);
                        break;
                    case "contains":
                        whereBuilder.Append($"{filter.Field}.Contains(@{i})");
                        parameters.Add(filter.Value);
                        break;
                    case "gt":
                        whereBuilder.Append($"{filter.Field} > @{i}");
                        parameters.Add(Convert.ChangeType(filter.Value, typeof(T).GetProperty(filter.Field)?.PropertyType ?? typeof(object)));
                        break;
                    case "lt":
                        whereBuilder.Append($"{filter.Field} < @{i}");
                        parameters.Add(Convert.ChangeType(filter.Value, typeof(T).GetProperty(filter.Field)?.PropertyType ?? typeof(object)));
                        break;
                    default:
                        throw new ArgumentException($"Desteklenmeyen operator: {filter.Operator}");
                }
            }

            query = query.Where(whereBuilder.ToString(), parameters.ToArray());
        }

        if (dynamicQuery.Sorts != null && dynamicQuery.Sorts.Any())
        {
            var sortString = string.Join(", ", dynamicQuery.Sorts.Select(s => $"{s.Field} {s.Direction}"));
            query = query.OrderBy(sortString);
        }

        return query;
    }
}
