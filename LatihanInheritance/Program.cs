using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Leo", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("AR", 30, "191128", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Aveiro", 19, "2796", "leo.richardo@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}