using System;

namespace CTExtensions
{
    public static class GuidExtension
    {
        /// <summary>
        /// Check if the given guid is null or empty
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool NullOrEmpty(this Guid id)
        {
            if (id == null)
            {
                return true;
            }
            else
            {
                if (id == Guid.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if the given guid is null or empty
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool NullOrEmpty(this Guid? id)
        {
            if (!id.HasValue)
            {
                return true;
            }
            else
            {
                if (id.Value == Guid.Empty)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
