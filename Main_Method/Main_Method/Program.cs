using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            //Addition add = new Addition();
            //int result = add.AddTwoNumbers(1, 2);
            //Console.WriteLine(result);
            //Console.ReadLine();

            // Passing in a decimal
            // Returns 2.3
            Addition add = new Addition();
            double result = add.AddTwoNumbers(1.1, 1.2);
            Console.WriteLine(result);
            Console.ReadLine();


            // Passing in a string that equates to an integer
            // Returns "23" 
            //Addition add = new Addition();
            //int result = Int32.Parse(add.AddTwoNumbers("2", "3"));
            //Console.WriteLine(result);
            //Console.ReadLine();

        }
    }
}
