using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Builder.Demo1
{
    //Step 1: Create the Product Class
    public class Car
    {
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public int Seats { get; set; }
        public bool Sunroof { get; set; }

        public override string ToString()
        {
            return $"Car [Engine={Engine}, Transmission={Transmission}, Seats={Seats}, Sunroof={Sunroof}]";
        }
    }

}
