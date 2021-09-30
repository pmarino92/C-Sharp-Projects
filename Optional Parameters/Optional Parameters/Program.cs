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
            try
            {
                Operator operatorObject = new Operator();
                Console.WriteLine("Pick a number:");
                int data = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number--optional");
                int input = Convert.ToInt32(Console.ReadLine());

                int result = operatorObject.operate(data, input);


                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("You entered nothing...default is 0");
                
             
                Console.ReadLine();
            }
        }
    }
}
