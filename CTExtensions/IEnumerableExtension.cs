using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTExtensions
{
    public static class IEnumerableExtension
    {
        public static bool HasItem<TSource>(this IEnumerable<TSource> ieInterface)
        {
            if (ieInterface.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
