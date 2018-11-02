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
            json.AddProperty("Prop1", "str1");
            json.AddProperty("Prop2", DateTime.Now);
            json.AddProperty("Prop3", 3);
            json.AddProperty("Prop4", Guid.NewGuid());
            json.AddProperty("Prop5", null);


            var str1 = json.GetProperty<string>("Prop1");
            var str2 = json.GetProperty<string>("Prop2", true);


            Console.WriteLine($"{str1}  {str2}");


            if (json.GetProperty<string>("Prop1") == str1)
            {
                Console.WriteLine($"Prop1屬性還在");
            }

            if (json.GetProperty<string>("Prop2") == null)
            {
                Console.WriteLine($"Prop2屬性已移除");
            }

            var int3 = json.GetProperty<int>("Prop3");
            Console.WriteLine(int3);

            var dat4 = json.GetProperty<Guid>("Prop4");
            Console.WriteLine(dat4);



            Console.ReadKey();
        }
    }
}
