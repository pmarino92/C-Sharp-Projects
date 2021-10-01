using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating employee object
            Employee employee = new Employee();
            // Assigning first name
            employee.FirstName = "Sample";
            // Assigning last name
            employee.LastName = "Student";

            // Calling SayName method
            // Returns Name: SampleStudent to console
            employee.SayName();
            employee.Quit(employee);

            // Using polymorphism to create an object
            // Of type IQuittable
            IQuittable quit = new Employee();
            quit.Quit(employee);
            Console.ReadLine();
        }
    }
}
