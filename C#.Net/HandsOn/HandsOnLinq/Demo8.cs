using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo8
    {
        static void Main()
        {
            int[] numbers = { 12, 23, 34, 45, 48, 56 };
            //deferred execution
            var result = (from k in numbers
                         where k > 40
                         select k);
            numbers[0] = 89;
            //query get executed at the time of iteration
            foreach(var i in result)
            {
                Console.WriteLine(i); // 89 45 48 56
            }
            Console.WriteLine();
            //immediate execution
            //ToArray(),TOList(),First(),Single(),Last()
            int[] numbers2 = { 12, 34, 45, 56, 67 };
            var r = numbers2.Where(n => n % 2 == 0).ToArray(); //query get executed immediately
            r = (from n in numbers2
                 where n % 2 == 0
                 select n).ToArray();
            numbers2[2] = 46;
            foreach (var i in r)
                Console.WriteLine(i);
        }
    }
}
