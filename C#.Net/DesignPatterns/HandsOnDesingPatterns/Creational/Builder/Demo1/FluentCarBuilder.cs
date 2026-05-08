using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
    internal class FluentCarBuilder
    {
        private Car _car = new Car();
        public FluentCarBuilder WithEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }
        public FluentCarBuilder WithTransmission(string transmission)
        {
            _car.Transmission = transmission;
            return this;
        }
        public FluentCarBuilder WithSeats(int seats)
        {
            _car.Seats = seats;
            return this;
        }
        public FluentCarBuilder HasSunroof(bool sunroof)
        {
            _car.Sunroof = sunroof;
            return this;
        }
        public Car Build() => _car;
    }
}
