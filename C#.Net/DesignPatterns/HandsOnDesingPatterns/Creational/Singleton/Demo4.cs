using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Singleton_Demo4
{
    public sealed class Logger
    {
        private static Logger _instance; // Private static instance
        private static readonly object _lock = new object(); // Lock object for thread safety

        // Private constructor to prevent external instantiation
        private Logger()
        {
            Console.WriteLine("Logger instance created");
        }

        // Double-checked locking for thread-safe lazy initialization
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Logger.Instance.Log("Application started.");
            Logger.Instance.Log("Performing some operations...");
            Logger.Instance.Log("Application ended.");
        }
    }
    
}
