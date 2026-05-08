using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Singleton_Demo1
{
    public sealed class Logger //prevents subclassing that could create multiple instances.
    {
        //create a private static instance of the class
        // prevents external construction.
        private static readonly Logger _instance = new Logger(); // initializes a single instance.
        //create private constructor to prevent instantiation
        private Logger() { }
        //exposes that instance.
        public static Logger Instance => _instance; //public static property to get the instance
        //exposes that instance.
        public void Log(string message)
        {
            Console.WriteLine($"[Log]: {message}");
        }
    }
    internal class Program    
    {
        static void Main()
        {
            Logger.Instance.Log("Welcome");
            Logger.Instance.Log("Good Morning");
        }
    }
}
