using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
    //Step 3: Create Concrete Builders
    internal class SportsCarBuilder: ICarBuilder
    {
        private Car _car = new Car();

        public void SetEngine() => _car.Engine = "V8 Turbo Engine";
        public void SetTransmission() => _car.Transmission = "Manual 6-Speed";
        public void SetSeats() => _car.Seats = 2;
        public void SetSunroof() => _car.Sunroof = true;

        public Car GetCar() => _car;
    }
}
