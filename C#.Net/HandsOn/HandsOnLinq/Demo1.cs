using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo1
    {
        static void Main()
        {
            string[] cities = { "Pune", "Chennai", "Hyderabad", "Banglore", "Delhi", "Bopal" };
            //fetch cities with lenght >4
            var result=from c in cities
                       where c.Length>4
                       select c.ToUpper();
            var result1 = cities.Where(s => s.Length > 4).Select(n => n.ToUpper());
            //fetch cities starts with B
             result=from c in cities
                       where c.StartsWith("B")
                       select c.ToUpper();
            result1 = cities.Where(s => s.StartsWith("B")).Select(n => n.ToLower());
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
