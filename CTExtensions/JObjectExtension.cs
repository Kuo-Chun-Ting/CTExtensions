using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTExtensions
{
    public static class JObjectExtension
    {
        /// <summary>
        /// 從JObject取得string value
        /// </summary>
        /// <param name="jsonProperties"></param>
        /// <param name="propName">the property name you want to get</param>
        /// <param name="isRemove">whether delete the property after getting</param>
        /// <returns></returns>
        public static string GetStringProperty(this JObject jsonProperties, string propName, bool isRemove = false)
        {
            try
            {
                var jToken = jsonProperties?.GetValue(propName);
                if (jToken != null)
                {
                    var value = jToken?.ToString();


                    if (isRemove)
                    {
                        jsonProperties.Remove(propName);
                    }


                    return value;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
