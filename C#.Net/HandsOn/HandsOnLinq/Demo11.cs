using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo11
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 12, 23, 34, 45, 56, 56 };
            //return square of list numbers
            var result = from n in numbers
                         select n * n;
            //return sqaure of list numbers>1000
            result = from n in numbers
                     let k = n * n
                     where k > 1000
                     select k;
            foreach (var i in result)
                Console.WriteLine(i);
        }
    }
}
