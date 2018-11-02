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
        public static T GetProperty<T>(this JObject jsonProperties, string propName, bool isRemove = false)
        {
            try
            {
                var jToken = jsonProperties.GetValue(propName);
                if (jToken != null)
                {
                    var value = jToken.ToObject<T>();


                    if (isRemove)
                    {
                        jsonProperties.Remove(propName);
                    }


                    return value;
                }
                return default(T);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 新增一屬性到JObject中
        /// </summary>
        /// <param name="jObject"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        public static bool AddProperty(this JObject jObject, string property, object value)
        {
            try
            {
                if (jObject?[property] != null)
                {
                    jObject.Remove(property);
                }
                var jToken = value != null ? JToken.FromObject(value) : null;
                jObject.Add(property, jToken);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
