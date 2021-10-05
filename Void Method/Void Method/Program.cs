using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtraction sub = new Subtraction(); //instantiate the class

            //calling the method passing in two numbers
            sub.Sub(4, 2); 

            // calling the method specifying the parameters by name
            
            sub.Sub(a: 4, b: 2 );
            Console.ReadLine();
            
        }
    }
}
