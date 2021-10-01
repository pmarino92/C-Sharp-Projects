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
    }
}
