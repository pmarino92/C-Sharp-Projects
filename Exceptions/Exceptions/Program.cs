using System;
using System.Collections.Generic;


class Program
{
   static void Main(string[] args)
   {
        // Creating a list of integers
        List<int> numList = new List<int>() { 2, 4, 6, 8, 10 };
        Console.WriteLine("Select a number to divide each number in our list");

        // Creating a for loop 
        // Divides each number in the list by the user generated number

            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numList.Count; i++)
                {
                    int finalNum = numList[i] / userNum;
                    Console.WriteLine(finalNum);
                    
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero is not possible");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                Console.WriteLine("Thank you have a great day!");
                
                Console.ReadLine();

            }
        


        




       




































        //try
        //{
        //    Console.WriteLine("Pick a number");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " is equal to " + numberThree);
        //    Console.ReadLine();
        //}

        //catch(FormatException ex)
        //{
        //    Console.WriteLine("Please type a number");
        //    return;
        //}
        //catch(DivideByZeroException ex)
        //{
        //    Console.WriteLine("Dividing by zero is not possible");
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}
        //Console.ReadLine();
        
   }
}

