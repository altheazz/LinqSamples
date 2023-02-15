using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();
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
