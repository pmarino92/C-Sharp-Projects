using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a number
            Console.WriteLine("Enter a number...");

            // Create a variable to take in user number
            string value = Console.ReadLine();

            //// Log the number to a text file
            File.WriteAllText(@"C:\Users\phili\Logs\log.txt", value);

            // StreamReader Constructor
            StreamReader sr = new StreamReader(@"C:\Users\phili\Logs\log.txt");

            // Read the line of text
            string line = sr.ReadLine();

            while(line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            // close the file 
            sr.Close();
            Console.ReadLine();
        }
    }
}
