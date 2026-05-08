using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
    //Step 5: Client Code (Usage)
    class Program
    {
        static void Main()
        {
            var director = new CarDirector();

            // Build Sports Car
            ICarBuilder sportsBuilder = new SportsCarBuilder();
            Car sportsCar = director.Construct(sportsBuilder);
            Console.WriteLine("Sports Car: " + sportsCar);

            // Build SUV Car
            ICarBuilder suvBuilder = new SUVCarBuilder();
            Car suvCar = director.Construct(suvBuilder);
            Console.WriteLine("SUV Car: " + suvCar);
            // // Usage of Fluent Builder
            var car = new FluentCarBuilder()
                   .WithEngine("V8")
                   .WithTransmission("Automatic")
                   .WithSeats(4)
                   .HasSunroof(true)
                   .Build();

            Console.WriteLine(car);
        }
    }

}
