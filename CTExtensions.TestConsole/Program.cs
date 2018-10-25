using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CTExtensions.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CTExtensions!");

            JObject json = new JObject();
            json.Add("Prop1", "str1");
            json.Add("Prop2", "str2");
            json.Add("Prop3", 3);


            var str1 = json.GetStringProperty("Prop1");
            var str2 = json.GetStringProperty("Prop2", true);


            Console.WriteLine($"{str1}  {str2}");


            if (json.GetStringProperty("Prop1") == str1)
            {
                Console.WriteLine($"Prop1屬性還在");
            }

            if (json.GetStringProperty("Prop2") == null)
            {
                Console.WriteLine($"Prop2屬性已移除");
            }

            var int3 = json.GetStringProperty("Prop3");
            Console.WriteLine(int3);


            Console.ReadKey();
        }
    }
}
