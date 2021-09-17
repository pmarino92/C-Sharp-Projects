using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_And_Comparison_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starts by printing “Anonymous Income Comparison Program”
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            // Store person 1 input as integer for their Hourly Rate
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            // Store Person 1 input as integer for hours worked per week
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek = Convert.ToInt32(Console.ReadLine());

            // Prints Person 2
            Console.WriteLine("Person 2");
            // Store person 2 input as integer for their Hourly Rate
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            // Store Person 2 input as integer for hours worked per week
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            

            // Prints Annual salary of Person 1
            Console.WriteLine("Annual salary of Person 1:");
            // Create variable to hold annual salary for Person 1 
            // Multiple hourly Rate times hours per week by 52 
            // 52 is how many weeks are in year
            int salary = hourlyRate * hoursPerWeek * 52;
            Console.WriteLine(salary);

            // Prints Annual salary of Person 2
            Console.WriteLine("Annual salary of Person 2:");
            // Create variable to hold annual salary for Person 1 
            // Multiple hourly Rate times hours per week by 52 
            // 52 is how many weeks are in year
            int salary2 = hourlyRate2 * hoursPerWeek2 * 52;
            Console.WriteLine(salary2);

            // Does Person 1 make more money than Person 2?
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            // Compares the two salaries and prints either true or false
            Console.WriteLine(salary >= salary2);
            Console.ReadLine();
            
        }
    }
}
