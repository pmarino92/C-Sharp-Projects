using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting first parameter from user
            Operator operatorObject = new Operator();
            Console.WriteLine("Enter a number");
            int data = Convert.ToInt32(Console.ReadLine());

            try
            {
                // Trying to get second parameter from user
                Console.WriteLine("Enter another number--optional");
                int input = Convert.ToInt32(Console.ReadLine());

                // If we get a 2nd parameter form user
                // Call method with both parameters
                int result = operatorObject.operate(data, input);

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch
            {
                // if the user doesn't enter a 2nd parameter 
                // run the method with only one parameter
                // 2nd parameter is optional so the default is 0
                int result = operatorObject.operate(data);
                Console.WriteLine(result);
                Console.ReadLine();
                
            }
        }
    }
}
