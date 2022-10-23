using System;
using System.Collections.Generic;

namespace Ilya02Il.BaseTypes.Extensions
{
    /// <summary>
    /// Методы расширения для <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Метод расширения, выполняющий <paramref name="predicate"/> для каждого элемента <paramref name="enumerable"/>.
        /// </summary>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> predicate)
        {
            foreach (var item in enumerable)
                predicate(item);
        }

        /// <inheritdoc cref="string.Join(string?, IEnumerable{string?})"/>
        public static string Join(this IEnumerable<string> sequence, string separator = "") =>
            string.Join(separator, sequence);
    }
}
