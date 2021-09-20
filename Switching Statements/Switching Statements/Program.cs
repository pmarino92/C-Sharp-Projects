using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switching_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting our number at 0
            int num = 0;
            do
            {
                ++num;
                Console.WriteLine("Num is now " + num);
            }

            // while our number is less than 10
            // increment our variable "num" by 1
            while (num < 10);
         
            Console.ReadLine();
        }
    }
}
