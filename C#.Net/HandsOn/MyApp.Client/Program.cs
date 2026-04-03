using Myapp.CalculateLibrary;
using System.Net.Http.Headers;
namespace MyApp.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();
            Console.WriteLine(obj.Add(2, 3));
            Console.WriteLine(obj.Mul(4, 5));
            Console.WriteLine(obj.Sub(10, 2));
            Console.WriteLine(obj.Square(3));
        }
    }
}
