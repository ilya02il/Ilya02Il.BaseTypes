using System;
using System.Collections.Generic;

namespace Ilya02Il.BaseTypes.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> predicate)
        {
            foreach (var item in enumerable)
                predicate(item);
        }

        public static string Join(this IEnumerable<string> sequence, string separator = "") =>
            string.Join(separator, sequence);
    }
}
