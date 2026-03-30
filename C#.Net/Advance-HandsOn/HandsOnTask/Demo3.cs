using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTask
{
    internal class Demo3
    {
        static void Main()
        {
            Task<int> task = Task.Run(() =>
            {
                return 1 + 2;
            });
            Console.WriteLine(task.Result);
        }
    }
}
