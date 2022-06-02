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

            Console.WriteLine("\nNow, write one additional number");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            Math adding = new Math(); //Creates a new multiplication object to be imported from Math.cs
            adding.add(userNum1, userNum2); //assigns object to 'result1'





            Console.ReadLine();


        }
    }
}
