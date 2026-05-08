using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
    //Step 4: Create the Director Class

    //Director defines the order of building steps.
    internal class CarDirector
    {
        public Car Construct(ICarBuilder builder)
        {
            builder.SetEngine();
            builder.SetTransmission();
            builder.SetSeats();
            builder.SetSunroof();
            return builder.GetCar();
        }
    }
}
