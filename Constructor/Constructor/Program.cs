using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Creating a constant variable
            //// this variable can not change
            //const string myName = "Phil";
            //Console.WriteLine("Hello my name is {0}", myName);

            //// Creating a variable using "var"
            //var gfName = "Taylor";
            //Console.WriteLine("My girlfriend's name is {0}", gfName);
            //Console.ReadLine();

            // Chaining Constructor
            var person = new NewEmployee("Erik");
            Console.WriteLine(person.firstName + person.lastName);
            Console.ReadLine();
        }
    }
}
