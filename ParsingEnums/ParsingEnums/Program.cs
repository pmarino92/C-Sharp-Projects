using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("What day is it?");
                // storing user input as a string 
            string value = Console.ReadLine();

                // Parsing through the enum
            DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);

                // if user inputs correct day then "Today is Tuesday" will print
            if(day == DaysOfTheWeek.Tuesday)
            {
                Console.WriteLine("Today is Tuesday");
            }

            }

            catch
            {
                Console.WriteLine("Please enter an actual day");
                

            }







            Console.ReadLine();
            

        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday, 
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
