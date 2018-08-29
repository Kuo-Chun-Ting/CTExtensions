using System;

namespace CTExtensions
{
    public static class GuidExtension
    {
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
