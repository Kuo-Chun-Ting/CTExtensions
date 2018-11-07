using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTExtensions
{
    public static class StringExtension
    {
        public static JObject ToJObject(this string str)
        {
            try
            {
                var jObject = JsonConvert.DeserializeObject<JObject>(str);
                return jObject;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
