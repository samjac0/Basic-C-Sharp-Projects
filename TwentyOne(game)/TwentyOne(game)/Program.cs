using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Grand Hotel and Casino. : let's start by telling me your name.");
            string pName = Console.ReadLine();
            
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", pName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(pName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for Playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.ReadLine();

            Deck deck = new Deck();
          

            Console.ReadLine();

        }
        

      
    }
}

//string text = File.ReadAllText( 

//public static Deck Shuffle(Deck deck, int times)
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;
//}



//deck.Cards = new List<Card>();


//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";
//deck.Cards.Add(cardOne);



//List<Card> cards = deck.Cards.Where(x => x.Face == Face.King).ToList();
//foreach (Card card in cards)
//{
//    Console.WriteLine(card.Face);
//}
//deck.Shuffle();
//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.ReadLine();


//DateTime dateTime = new DateTime(2018, 11, 23);
//DateTime Graduate = new DateTime(2020, 12, 23);
//TimeSpan yearsGraduate = Graduate - dateTime;