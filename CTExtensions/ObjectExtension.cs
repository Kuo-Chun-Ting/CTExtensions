using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTExtensions
{
    public static class ObjectExtension
    {
        public static string ToJson(this object obj)
        {
            try
            {
                var json = JsonConvert.SerializeObject(obj);
                return json;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
