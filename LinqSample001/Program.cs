using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            
            //Query Expression //select必須寫
            List<MyData> list = CreateList();

            IEnumerable<MyData> people =  //<string>              
                from data in list
                where data.Name == "Bill"
                select data; //data."neme"
            */

            //Method Expression //select可寫可不寫
            var list = CreateList();

            var people = list.Where((x) => x.Name == "Bill"); //x 相對於第一種作法的參數data
            //== var people = Enumerable.Where(list, (x) => x.Name == "Bill");
            //.Select((x) => x.Name) //嘗試

            //顯示結果
            foreach (MyData person in people) 
            {
                Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
            }
            Console.ReadLine();



        }
        static  List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData{ Name = "Bill", Age = 47},
                new MyData{ Name = "Jhon", Age = 37},
                new MyData{ Name = "Tom", Age = 48},
                new MyData{ Name = "David", Age = 36},
                new MyData{ Name = "Bill", Age = 35},
            };
        }
    }
}
