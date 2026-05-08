using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
   // Step 2: Create the Builder Interface
    public interface ICarBuilder
    {
        void SetEngine();
        void SetTransmission();
        void SetSeats();
        void SetSunroof();
        Car GetCar();
    }

}
