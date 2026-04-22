using System.Threading;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Task()
        {
            Console.WriteLine("Task is Running");
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(Task);
            t1.Start();
        }
    }
}
