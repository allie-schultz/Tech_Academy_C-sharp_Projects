using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            //Number guessing game

            Console.WriteLine("Guess a number between 1 and 100:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool guess = num == 27;

            do //do while loop
            {
                if (num == 27)
                {
                    Console.WriteLine("You guessed 27, that is correct!");
                    guess = true;
                }
                else if (num < 27)
                {
                    Console.WriteLine("Your guess is too low, try again.");
                    Console.WriteLine("Guess a number between 1 and 100:");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Your guess is too high, try again.");
                    Console.WriteLine("Guess a number between 1 and 100:");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (!guess);
            Console.ReadKey();




            Random random = new Random();
            bool playing = true;
            string guessCoin = "";
            Console.WriteLine("\nWelcome to the coin flip guessing game!");

            while (playing) //while loop
            {
                Console.WriteLine("Guess heads (h) or tails (t): ");
                guessCoin = Console.ReadLine().ToLower();

                if (guessCoin != "h" && guessCoin != "t")
                {
                    Console.WriteLine("Invalid input. Please enter 'h' for heads or 't' for tails.");
                    continue;
                }
                int flip = random.Next(0, 2);
                string flipResult = flip == 0 ? "heads" : "tails";

                Console.WriteLine("The coin flip result is: " + flipResult);

                bool correctGuess = (guessCoin == "h" && flipResult == "heads") || (guessCoin == "t" && flipResult == "tails");

                if (correctGuess)
                {
                    Console.WriteLine("You guessed correctly! Let's go again");
                }
                else
                {
                    Console.WriteLine("Sorry, you guessed wrong. Game Over...dun dun duhnnn");
                    playing = false;
                }
                
            }
            Console.Read();























            //Console.WriteLine("Guess a number?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 12;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62, try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29, try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55, try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12, that is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);

            //Console.Read();
        }
    }
}
