using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // Taking user input for package weight 
            Console.WriteLine("Package Weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }

            // Taking user input for package width
            Console.WriteLine("Package Width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Taking user input for package length
            Console.WriteLine("Package Length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // variable to calculate package dimensions
            int dimensions = packageWeight * packageWidth * packageLength;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }

            // Displaying our quote to the user
            int quote = packageWeight * packageWidth * packageLength * 100;
            Console.WriteLine("Your egregiously overpriced shipping cost is: " + quote);


            Console.ReadLine();
        }
    }
}
