using System;
using System.Collections.Generic;

namespace System.Linq
{
    public static class StringExtensions
    {
        public static string Join<TItem>(this IEnumerable<TItem> enumerable, string separator)
        {
            return string.Join(separator, enumerable.Select(x => x.ToString()).ToArray());
        }
    }
}
