using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Singleton_Demo2
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton Instance => instance ??= new Singleton();
        public void ShowMessage(string message)
        {
            Console.WriteLine($"[Message]: {message}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Singleton.Instance.ShowMessage("Hello, Singleton!");
            Singleton.Instance.ShowMessage("This is a lazy initialized singleton.");
        }
    }
}
