using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
    //Step 3: Create Concrete Builders
    public class SUVCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void SetEngine() => _car.Engine = "V6 Diesel Engine";
        public void SetTransmission() => _car.Transmission = "Automatic 8-Speed";
        public void SetSeats() => _car.Seats = 7;
        public void SetSunroof() => _car.Sunroof = false;

        public Car GetCar() => _car;
    }

}
