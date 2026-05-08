using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Factory_Demo1
{
    public interface IShape
    {
        void Draw();
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }   
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
    public class ShapeFactory
    {
        public static IShape CreateShape(string shapeType)
        {
            return shapeType.ToLower() switch
            {
                "circle" => new Circle(),
                "square" => new Square(),
                _ => throw new ArgumentException("Invalid shape type"),
            };
        }
    }
    internal class Program
    {
        static void Main()
        {
            var shape = ShapeFactory.CreateShape("Circle");
            shape.Draw();
        }
    }
}
