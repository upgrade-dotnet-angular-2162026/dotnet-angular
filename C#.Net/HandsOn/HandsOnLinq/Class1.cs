using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Doctor
    {
        public int Id { get; set; }
    }
    internal class Class1
    {
        static void Main()
        {
            var doctor = new Doctor() { Id = 393 };
            List<Doctor> doctors = new List<Doctor>() { doctor };
            foreach(var d in doctors)
            {

            }
        }
    }
}
