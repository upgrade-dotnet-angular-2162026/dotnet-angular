using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Factory_Demo2
{
    // Product interface
    public interface IVehicle
    {
        void Drive(int miles);
    }

    // Concrete products
    public class Scooter : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles + "km");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles + "km");
        }
    }

    // Factory class
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle '{vehicleType}' cannot be created");
            }
        }
    }

    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new VehicleFactory();

            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10); // Output: Drive the Scooter : 10km

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(20); // Output: Drive the Bike : 20km
        }
    }

}
