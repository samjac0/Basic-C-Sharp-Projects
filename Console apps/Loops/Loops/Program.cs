using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        
        
        {
            //while comparison
            Console.WriteLine("Do you want to play a game? Type yes or no");
            string game = Console.ReadLine();
            bool boolGame = game == "yes";

            while (!boolGame)
            {
                switch (game)
                {
                    case "yes":
                        Console.WriteLine("Let's Play!");
                        boolGame = true;
                        break;
                    default:
                        Console.WriteLine("But you must, it is your destiny");
                        Console.WriteLine("\nDo you want to play a game? Type yes or no");
                        game = Console.ReadLine();
                        break;
                }
            }

                //do-while comparison
                Console.WriteLine("\n\nGuess a number between 1-15?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. You guessed " + number + " and that is incorrect.");
                        Console.WriteLine("\nGuess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
