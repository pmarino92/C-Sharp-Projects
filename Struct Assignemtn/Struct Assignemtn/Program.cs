using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignemtn
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of data type Number
            // assign amount to 4.5
            Number num = new Number();
            num.Amount = 4.5;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
