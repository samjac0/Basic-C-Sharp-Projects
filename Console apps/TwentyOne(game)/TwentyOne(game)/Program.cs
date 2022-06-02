
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne_game_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}: let's start by telling me your name.", casinoName);
            string pName = Console.ReadLine();
            if (pName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.WriteLine(exception.Id + " | ");
                    Console.WriteLine(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | ");
                    Console.WriteLine(exception.TimeStamp);
                    Console.WriteLine();
                }
                Console.Read();
                return;

            }
            

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please answer with whole numbers only");
            }
            
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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine("You entered an incorrect amount. The game admininistration security has been notifed.");
                        UpdateDbWithExeption(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your system admininstrator. This program will now end.");
                        UpdateDbWithExeption(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for Playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.ReadLine();

            Deck deck = new Deck();
          

            Console.ReadLine();

        }
        
        private static void UpdateDbWithExeption(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='TwentyOne Game';
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='TwentyOne Game';
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["Timestamp"]);
                    ReadExceptions().Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
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