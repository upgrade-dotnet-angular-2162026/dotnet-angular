using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTask
{
    internal class Demo4
    {

        static void Main()
        {
            //create task using constructor
            Task t1 = new Task(() =>
            {
                Console.WriteLine("Welcome to Task Programming!!");
            });
            t1.Start(); //start the task
            t1.Wait(); //It waits main thread to complete the task t1
            Console.WriteLine("Task Completed");
        }
    }
}
