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


            Deck deck = new Deck();
           
            List<Card> cards = deck.Cards.Where(x => x.Face == Face.King).ToList();
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Face);
            }
            
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