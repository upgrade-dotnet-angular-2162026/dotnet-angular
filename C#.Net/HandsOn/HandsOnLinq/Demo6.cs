using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    public record Student(int studentId,string name);
    public record Enroll(int studentId, string course);
    public record StudentEnroll(int studentId, string name,string course);
    internal class Demo6
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"Ram"),
                new Student(2,"Tina"),
                new Student(3,"Taran")
            };
            List<Enroll> enrolls = new List<Enroll>()
            {
                new Enroll(1,"Dotnet"),
                 new Enroll(2,"Java"),
                  new Enroll(3,"Python"),
                   new Enroll(1,"Azure"),
                    new Enroll(2,"AWS"),
                     new Enroll(3,"GCP"),
            };
            //Joining 2 data source
            var result = from student in students
                         join enroll in enrolls
                         on student.studentId equals enroll.studentId
                         select new StudentEnroll(student.studentId, student.name, enroll.course);
            foreach(var item in result)
                Console.WriteLine($"Id:{item.studentId} Name:{item.name} course:{item.course}");
            //grouping data
            //grouing the coursed by student name
            var groupresult = from item in result
                              group item by item.name;
            foreach(var item in groupresult)
            {
                Console.WriteLine("Courses Entrolled by " + item.Key+" and Count "+item.Count()); //key return group by prop value
                foreach(var e in item)
                {
                    Console.WriteLine(e.course);
                }
            }

        }
    }
}
