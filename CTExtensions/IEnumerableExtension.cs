using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTExtensions
{
    public static class IEnumerableExtension
    {
        public static bool HasItem<TSource>(this IEnumerable<TSource> source)
        {
            if (source != null)
            {
                if (source.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Foreach run a given Task delegate in the collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static async Task ParallelForeachAsync<T>(this IEnumerable<T> source, Func<T, Task> action)
        {
            List<Task> missionList = new List<Task>();
            foreach (var item in source)
            {
                var mission = action(item);
                missionList.Add(mission);
            }
            await Task.WhenAll(missionList);
        }
    }
}
