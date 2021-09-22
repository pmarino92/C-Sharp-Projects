using System;
using System.Collections.Generic;
using System.Text;



    class Program
    {
        static void Main(string[] args)
    {
        

        //// PART ONE OF ASSIGNMENT
        //// Create an array 
        //string[] arrayOfWords = { "Books", "Cheese", "Trees", "Laughter" };
        //Console.WriteLine("Add a word to the array");

        //// Add user input to the end of each index
        //for (int i = 0; i < arrayOfWords.Length; i++)
        //{
        //    arrayOfWords[i] += Console.ReadLine();

        //}

        //// Creates a loop that prints off each string on a separate line
        //for (int i = 0; i < arrayOfWords.Length; i++)
        //{
        //    Console.WriteLine(arrayOfWords[i]);
        //}
        //Console.ReadLine();




        //// PART TWO/THREE OF ASSIGNMENT
        //// Creating an infinite loop
        //for (int j = 10; j >= 10; j++)
        //{
        //    Console.WriteLine("infinite loop", j);
        //}

        //// fixing our infinite loop with a "<=" operator
        //for (int j = 0; j <= 10; j++)
        //{
        //    Console.WriteLine("not an infinite loop anymore", j);
        //}

        //// comparison with "<" operator
        //for (int f = 0; f < 10; f++)
        //{
        //    Console.WriteLine("this should just go up to 10");
        //}
        //Console.ReadLine();




        //// PART FOUR OF ASSIGNMENT 
        //// creating a list of strings
        //List<string> authorList = new List<string> { "Mahesh Chand", "Stephen King", "Jane Austen", "J.K. Rowling", "Charles Dickens" };
        //// prompt user for input
        //Console.WriteLine("search list: ");
        //string inputsearch = Console.ReadLine();
        //bool authorFound = false;

        //// for loop to display index as well as matching text
        //for (int i = 0; i < authorList.Count; i++)
        //{
        //    if (authorList[i] == inputsearch)
        //    {
        //        Console.WriteLine(i + " " + authorList[i]);
        //        authorFound = true;

        //    }
        //}
        //if (!authorFound)
        //{
        //    Console.WriteLine("no authors were found");
        //}
        //Console.ReadLine();



        //// PART FIVE OF ASSIGNMENT
        //// Creating a list of strings with two identical strings
        //List<string> GameList = new List<string> { "Halo 3", "Pillars of Eternity", "Skyrim", "Pillars of Eternity", "Tell Me Why" };
        //// Prompt user for input
        //Console.WriteLine("Search List: ");
        //string searchList = Console.ReadLine();
        //bool gameFound = false;

        //// For loop to display index as well as matching text
        //for (int j = 0; j < GameList.Count; j++)
        //{
        //    if (GameList[j] == searchList)
        //    {
        //        Console.WriteLine(j + " " + GameList[j]);
        //        gameFound = true;

        //    }
        //}
        //if (!gameFound)
        //{
        //    Console.WriteLine("No games were found");
        //}
        //Console.ReadLine();


        // PART 6 OF ASSIGNMENT
        // Creating a list of strings with two identical strings part 2
        List<string> CarList = new List<string> { "Camaro", "Ford F-150", "Dodge Ram", "Lamborghini", "Camaro" };

        Console.WriteLine("Search List of Cars: ");
        
        
        
        // Foreach Loop that evaluates whether a string has already appeared
        foreach(string value in CarList)
        {
            if(value == "Camaro")
            {
                Console.WriteLine(value + " has already appeared");
               
                
            }
            else 
            {
                Console.WriteLine(value);
                
            }
            
        }
        Console.ReadLine();




    }
}

