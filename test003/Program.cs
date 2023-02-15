using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();

            /*
            var result = list.GroupBy((x) => x.City);
            foreach(var item in result)
            {
                Console.WriteLine($"住在：{item.Key}");
                foreach(var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("-------");
            }
            */


            var result = 
                from o in list
                group o by o.City into gp
                select gp;
            foreach ( var item in result ) 
            {
                Console.WriteLine($"住在：{item.Key}");
                foreach(var p in item )
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("---------");
            }
            Console.ReadLine();
        }

        static List<Class1> Createlist()
        {
            return new List<Class1>()
            {
                new Class1 { Name = "Bill", City = "台北"},
                new Class1 { Name = "Jhon", City = "台北" },
                new Class1 { Name = "Tom", City = "高雄" },
                new Class1 { Name = "David", City = "台南" },
                new Class1 { Name = "Jeff", City = "台南" },
            };
        }
    }
}
