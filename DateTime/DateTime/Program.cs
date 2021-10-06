using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console.
            Console.WriteLine("Current date and time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            // Prompt the user for a number
            Console.WriteLine("Enter a number to find a later time");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The time will be: ");
            Console.WriteLine(DateTime.Now.AddHours(hour));
            Console.ReadLine();
        }
    }
}
