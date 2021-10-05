using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Input two numbers");
            Console.WriteLine("You don't need to input a 2nd number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter to Continue");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            int result = math.AddTwoNumbers(num1, num2: 10);
            
            
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
