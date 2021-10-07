using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class Employee
    {
        public Employee(string name) : this(name, 1)
        {

        }

        public Employee(string name, int Id)
        {
            Name = name;
            Id = Id;

        }
    }
}
