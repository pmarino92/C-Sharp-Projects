using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
        // Single-Dimensional string array
        string[] myArray = new string[3];
        myArray[0] = "Phil";
        myArray[1] = "Taylor";
        myArray[2] = "Erik";
        Console.WriteLine("Enter a number to display a string");
        // Store the number into a variable called "myIndex"
        int myIndex = int.Parse(Console.ReadLine());
        do
        {
            if (myIndex > 3)
            {
                Console.WriteLine("That index does not exit");
                break;
            }

            // Prints out the value at the given index
            Console.WriteLine("value is: " + myArray[myIndex]);
            Console.ReadLine();

        }
        // breaks the while loop
        while (false);

        // Single-Dimensional integer array
        int[] myIntArray = new int[3];
        myIntArray[0] = 100;
        myIntArray[1] = 200;
        myIntArray[2] = 300;
        Console.WriteLine("Enter a number to display an integer");
        // Store the number into a variable called "myIndex1"
        int myIndex1 = int.Parse(Console.ReadLine());
        do
        {
            if (myIndex1 > 3)
            {
                Console.WriteLine("That index does not exit");
                break;
            }

            // Prints out the value at the given index
            Console.WriteLine("value is: " + myIntArray[myIndex1]);
            Console.ReadLine();

        }
        // breaks the while loop
        while (false);

        // initialize our string array with 7 elements
        string[] strArray = new string[] { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
        // Prompt the question
        Console.WriteLine("Enter a number to display that index");
        // Store the number into a variable called "index"
        int index = int.Parse(Console.ReadLine());
        do
        {
            if (index > 7)
            {
                Console.WriteLine("That index does not exit");
                break;
            }

            // Prints out the value at the given index
            Console.WriteLine("value is: " + strArray[index]);
            Console.ReadLine();

        }
        // breaks the while loop
        while (false);
        Console.WriteLine("Thanks for joining me");
        Console.ReadLine();

    }
    }
