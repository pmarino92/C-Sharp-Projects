using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("New Employee");
            base.SayName();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("Employee has quit");
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if(employee.Id == employee2.Id)
            {
                
                return true;
                
            }
            else
            {
                Console.WriteLine("No Match");
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }

        public override bool Equals(object obj)
        {
            return true;
        }

    }
}
