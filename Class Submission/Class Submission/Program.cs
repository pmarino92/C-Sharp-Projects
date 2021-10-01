using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //// instantiate our class
            //Division divide = new Division();
            //// Prompt user to enter a number
            //// store user number in data
            //Console.WriteLine("Enter a number");
            //int data = Convert.ToInt32(Console.ReadLine());

            //// Call our method
            //divide.Divy(data);

            //// This will be our out param method
            //void Out(out int number)
            //{
            //    number = 69;
            //    Console.WriteLine("nice");
            //}

            //// Declaring number1 without assigning a value
            //int number1;

            //// Calling the method and passing it as an out parameter
            //Out(out number1);
            //Console.Write(number1);






            // Demonstrating overload methods
            // instantiate our new method
            Division addition = new Division();

            int sum1 = addition.Add(1, 2);
            Console.WriteLine("sum of the two is equal to " + sum1);

            int sum2 = addition.Add(1, 2, 3);
            Console.WriteLine("sum of the three is equal to " + sum2);


            // Demonstrating static classes
            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Mascot);



            Console.ReadLine();
        }
    }
}
