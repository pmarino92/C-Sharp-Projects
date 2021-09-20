using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating three strings
            string name = "Phil";
            string job = "Software Developer";
            string location = "Tennessee";
            // Creating a fourth string that is a concantenation of our above 3 strings
            string str = "Hi my name is " + name + ", and I am a " + job + " from " + location;
            Console.WriteLine(str);

            // Creating a variable "girlfriend" 
            // To demonstrate the ToUpper() string method
            string girlfriend = "Taylor";
            // Using the ToUpper method to capitalize our string girlfriend
            Console.WriteLine(girlfriend.ToUpper());


            // Creating a Stringbuilder 
            StringBuilder sb = new StringBuilder();

            // Adding three sentences
            sb.Append("My name is Phil.");
            sb.Append(" I am a Software Developer.");
            sb.Append(" From the state of Tennessee");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
