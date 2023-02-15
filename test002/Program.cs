using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6};
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9};

            //聯集
            var union = list1.Union(list2); //當list1和list2互換時，跑出來的結果順序會改變
            Console.WriteLine("聯集的結果為：");
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }

            //交集
            var intersect = list1.Intersect(list2);
            Console.WriteLine("交集的結果為：");
            foreach(var item in intersect) 
            { 
                Console.WriteLine(item); 
            }

            //差集
            var aEXb = list1.Except(list2);
            Console.WriteLine("A差集B的結果為：");
            foreach(var item in aEXb)
            {
                Console.WriteLine(item);
            }

            var bEXa = list2.Except(list1);
            Console.WriteLine("B差集A的結果為：");
            foreach (var item in bEXa)
            {
                Console.WriteLine(item);
            }
            
            //重複
            var list = new List<string>
            {"台北","台北","洛杉磯","紐約","紐約","台北"};
            var result = list.Distinct();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            */


            //
            var list = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var resultOfSkip = list.Skip(3);
            Console.WriteLine("skip(3)的結果");
            Display(resultOfSkip);

            var resultOfTake = list.Take(3);
            Console.WriteLine("take(3)的結果");
            Display(resultOfTake);

            var resultOfSkipTake = list.Skip(2).Take(2);
            Console.WriteLine("skip(2).take(3)的結果");
            Display(resultOfSkipTake);


            Console.ReadLine();

        }

        static void Display(IEnumerable<string> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
