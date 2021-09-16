using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // First two lines when starting program
            // Parentheses in comments denote data type
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            

            // First Question: What is your name? (string)
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // Second Question: What course are you on? (string)
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Third Question: What page number? (string)
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();

            // Fourth Question: Do you need help? (string/boolean)
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string yourResponse = Console.ReadLine();

            // Fifth Question: Any Feedback? (string)
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourFeedback = Console.ReadLine();

            // Sixth Question: How many hours did you study today? (integer/string)
            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();

            // Will print this message once all questions are answered
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
