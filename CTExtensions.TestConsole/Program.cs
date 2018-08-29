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

            Guid id1 = Guid.NewGuid();
            Guid id2 = new Guid(id1.ToString());
            Guid id3 = Guid.NewGuid();
            Guid id4 = Guid.Empty;
            Guid id5 = Guid.Empty;
            Guid? id6 = Guid.Empty;
            Guid? id7 = Guid.NewGuid();
            Guid? id8 = new Guid(id1.ToString());
            Guid? id9 = null;

            Console.WriteLine(id1.Equals(id2));
            Console.WriteLine(id1.Equals(id3));
            Console.WriteLine(id1.Equals(id4));
            Console.WriteLine(id4.Equals(id5));
            Console.WriteLine(id1.Equals(id6));
            Console.WriteLine(id1.Equals(id7));
            Console.WriteLine(id1.Equals(id8));
            Console.WriteLine(id1.Equals(id9));

            //Guid? id1 = null;
            //var r1 = id1.NullOrEmpty();

            //Guid? id2 = Guid.Empty;
            //var r2 = id2.NullOrEmpty();

            //Guid? id3 = Guid.NewGuid();
            //var r3 = id3.NullOrEmpty();


            //Guid id4 = Guid.Empty;
            //var r4 = id4.NullOrEmpty();

            //Guid id5 = Guid.NewGuid();
            //var r5 = id5.NullOrEmpty();

            //List<string> list1 = new List<string>();
            //var h1 = list1.HasItem();

            //list1.Add("test");
            //var h2 = list1.HasItem();

            //List<string> list2 = new List<string>();
            //var x1 = list2.AsQueryable().HasItem();

            //list2.Add("test");
            //var x2 = list2.AsQueryable().HasItem();


            Console.ReadKey();
        }
    }
}
