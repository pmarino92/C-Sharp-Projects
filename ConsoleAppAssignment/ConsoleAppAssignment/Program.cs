using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take input from user
            Console.WriteLine("Enter a number to be multiplied by 50");
            // Create a variable to store the user's desired number
            int userInput = Convert.ToInt32(Console.ReadLine());
            // This just multiplies the input by 50
            Console.WriteLine(userInput * 50);


            // Take input from user
            Console.WriteLine("Next, enter a number that will be added by 25");
            // Take in variable
            int secondInput = Convert.ToInt32(Console.ReadLine());
            // Equation to add 25 to the user's input
            Console.WriteLine(secondInput + 25);


            Console.WriteLine("This input will be divided by 12.5");
            // Converted data type to a double
            double thirdInput = Convert.ToDouble(Console.ReadLine());
            // This divides the input by 12.5
            Console.WriteLine(thirdInput / 12.5);
            

            Console.WriteLine("Check if greater than 50");
            // User input is an integer not a boolean
            int fourthInput = Convert.ToInt32(Console.ReadLine());
            // Checks user input 
            Console.WriteLine(fourthInput > 50);


            Console.WriteLine("This input will be divided by 7 then it will print the remainder");
            // Data type is an integer again
            int fifthInput = Convert.ToInt32(Console.ReadLine());
            // Takes user input, divides by 7, then prints remainder
            Console.WriteLine(fifthInput % 7);
            Console.ReadLine();






        }
    }
}
