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
            Employee employee2 = new Employee();
            // Assigning first name
            employee.FirstName = "Sample ";
            // Assigning last name
            employee.LastName = " Student";
            
            employee.SayName();

            // 2nd employee
            employee2.FirstName = "Phil ";
            employee2.LastName = "Marino";
            
            employee2.SayName();

            if(employee.Id == employee2.Id)
            {
                Console.WriteLine("Id Match");
            }
            else
            {
                Console.WriteLine("No Id Match");
            }


            
            



            // Calling SayName method
            // Returns Name: SampleStudent to console
            
            //employee.Quit(employee);

            // Using polymorphism to create an object
            // Of type IQuittable
            //IQuittable quit = new Employee();
            //quit.Quit(employee);
            Console.ReadLine();
        }
    }
}
