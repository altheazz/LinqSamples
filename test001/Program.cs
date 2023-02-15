using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();


            /*firstordefault尋找符合條件的第一個
             * 
            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於37歲的人第一個被找到的是：{person1.Name}");

            var person2 = list.First((x) => x.Age < 30);
            Console.WriteLine($"小於30歲的人第一個被找到的是：{person2.Name}");
            */

            /*lastordefault尋找符合條件的最後一個，但它是從第一個開始往下找最後一個
             * 
            var person1 = list.LastOrDefault((x) => x.Age > 35);
            Console.WriteLine($"大於35歲的人最後一個被找到的是：{person1.Name}");

            var person2 = list.Last((x) => x.Age > 50);
            Console.WriteLine($"大於50歲的人最後一個被找到的是：{person2.Name}");
           */

            /*
            var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的{person1.Name} - {person1.Age}");
            
            var person2 = list.Single((x) => x.Name == "Bill");
            Console.WriteLine($"找到唯一的：{person2.Name} - {person2.Age}");
            */


            /*
            //當有error產生時，建議先以if/else解決，不到最後建議先不使用try/catch，像null就不適用
            var person = list.FirstOrDefault((x) => x.Name == "李小龍");

            if(person == null) 
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到：{person.Name} - {person.Age}");
            }
            */


            /*
            //利用索引找到索引值
            int index = 1;

            var person = list.ElementAtOrDefault(index);
            if(person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為：{index}的人是{person.Name} - {person.Age}");
            }
            */
            /*
            string name = "David";
            
            bool result = list.Any((x) => x.Name == name);
            if(result )
            {
                Console.WriteLine($"找到人：{name}");
            }
            else
            {
                Console.WriteLine($"找不到：{name}");
            }
            */

            /*
            string name = "Bill";
            bool isAllBill = list.All((x) => x.Name == name);
            if(isAllBill)
            {
                Console.WriteLine($"全都是{name}");
            }
            else
            {
                Console.WriteLine($"有些人不叫{name}");
            }
            bool isAllOverForty = list.All((x) => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine($"大家都超過40歲");
            }
            else
            {
                Console.WriteLine($"有人不到40歲");
            }
            */

            /*list運算
            int total = list.Sum((x) => x.Age);
            Console.WriteLine($"年齡的總和為：{total}");

            var minAge = list.Min(x => x.Age);
            Console.WriteLine($"最小的年齡為：{minAge}");

            var maxAge = list.Max(x => x.Age);
            Console.WriteLine($"最大的年齡為：{maxAge}");


            //count != count()，count屬性 / count()方法
            int count = list.Count();
            Console.WriteLine($"list總個數為：{count}");

            int countofBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"list中的Bill總數量為：{countofBill}");

            var average = list.Average(x => x.Age);
            Console.WriteLine($"年齡的平均值為：{average}");
            */
            
            /*
            //複合查詢運算
            
            var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有Bill中最小的年齡是：{min}");

            var total = list.Where(x => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有Bill的年齡總和是：{total}");

            var average = list.Where(x => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有Bill的年齡平均是：{average}");
            */

            var result1 = list.Where((x) => x.Age > 40).ToList();
            var result2 = list.Where((x) => x.Age > 40).ToArray();

            var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);

            foreach(var item in result3) 
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"{item.Value.Name} -- {item.Value.Age}");
            }
            Console.WriteLine("-----------");

            var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);//此寫法不能下條件，如果有條件需求，須以第147行來要求
            foreach(var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }



            Console.ReadLine();
        }
            
        static List<Mydata> Createlist()
        { 
            return new List<Mydata>()
            {
                new Mydata { Name = "Bill", Age = 47},
                new Mydata { Name = "Jhon", Age = 37 },
                new Mydata { Name = "Tom", Age = 48 },
                new Mydata { Name = "David", Age = 36 },
                //new Mydata { Name = "Bill", Age = 35 },//todictionary資料不可重複
            };
        }
    }
}
