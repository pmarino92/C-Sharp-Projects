using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            //// Addition math operation
            //Console.WriteLine("Enter a number");

            //// Instantiate our calculator class
            //Calculator calc = new Calculator();
            //// Collect user input
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second number to complete the addition");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int result = calc.Add(num1, num2);
            //Console.WriteLine(num1 + " + " + num2 + " = " + result);





            //// Multiplication math operation
            //Console.WriteLine("Enter a number");

            //// Instantiate our calculator class
            //Calculator calc = new Calculator();
            //// Collect user input
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second number to complete the addition");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int result2 = calc.Multiply(num1, num2);
            //Console.WriteLine(num1 + " multiplied by " + num2 + " = " + result2);

            // Subtraction math operation
            Console.WriteLine("Enter a number");

            // Instantiate our calculator class
            Calculator calc = new Calculator();
            // Collect user input
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number to complete the addition");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result3 = calc.Subtract(num1, num2);
            Console.WriteLine(num1 + " minus " + num2 + " = " + result3);


            Console.ReadLine();


        }






//        Deck deck = new Deck();
//        deck = Shuffle(deck);

            
//            foreach(Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face + " of " + card.Suit);
//            }

//    Console.WriteLine(deck.Cards.Count);
//            Console.ReadLine();
//        }

//public static Deck Shuffle(Deck deck)
//{
//    List<Card> TempList = new List<Card>();
//    Random random = new Random();

//    while (deck.Cards.Count > 0)
//    {
//        int randomIndex = random.Next(0, deck.Cards.Count);
//        TempList.Add(deck.Cards[randomIndex]);
//        deck.Cards.RemoveAt(randomIndex);
//    }
//    deck.Cards = TempList;
//    return deck;

}

}
