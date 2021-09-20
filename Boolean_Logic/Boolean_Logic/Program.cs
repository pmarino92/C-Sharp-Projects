using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            //// Ask what user age is
            //// Store that number in userAge
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            //// Ask if user has had a DUI
            //// User response is a string
            Console.WriteLine("Have you ever had a DUI?");
            string userDUI = Console.ReadLine();

            //// Asking user how many speeding tickets they have
            //// Response will be an integer
            Console.WriteLine("How many speeding tickets do you have?");
            int userTicket = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qualified?");
            bool isQualified = (userAge > 15 && userDUI == "no" && userTicket < 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();

            

        }
    }
}
