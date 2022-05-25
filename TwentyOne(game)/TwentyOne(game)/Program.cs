using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_game_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game = game + player;
    
            
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            //deck = Shuffle(deck: deck, times: 3);
            deck.Shuffle();
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
          
            Console.ReadLine();

        }
        

     
    }
}

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