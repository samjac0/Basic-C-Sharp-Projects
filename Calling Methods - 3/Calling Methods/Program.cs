using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this fun little program featuring Methods!\nEnter a number to get started.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nNow, write one additional number if you would wish. Or, hit enter to leave it blank.");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            var addObject = new Math(); //Creates a new multiplication object to be imported from Math.cs

            if (userNum2 == null)
            {
                userNum2 = 0;
                string uNum2 = "A second number could have swept in and changed the final number. Sadly, there's non to be found";

                var result1 = addObject.add(userNum1, userNum2); //assigns object to 'result1'


                Console.WriteLine("Hey! Your number is " + userNum1 + " and we added 2 to that.\n" + uNum2 + "\nMaking the total a big whopping " + result1 + "!!");
            }
            else
            {
                string uNum2 = "A second number comes flying in and adds " + userNum2 + " to the mix. Wahoo!!";

                var result1 = addObject.add(userNum1, userNum2); //assigns object to 'result1'


                Console.WriteLine("Hey! Your number is " + userNum1 + " and we added 2 to that.\n" + uNum2 + "\nMaking the total a big whopping " + result1 + "!!");
            }

            Console.ReadLine();


        }
    }
}
