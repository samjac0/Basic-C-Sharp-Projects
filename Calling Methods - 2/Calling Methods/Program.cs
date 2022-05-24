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
            Console.WriteLine("Welcome to this fun little program featuring Methods!\nFirst, enter a whole number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSecond, add a number. But this time, add a decimal.");
            decimal userNum2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nLast, type a whole number OR decimal. ");
            string userNum3 = Console.ReadLine();



            Math math = new Math(); //Creates a new multiplication object to be imported from Math.cs

            int result1 = math.maths(userNum1); //assigns object to 'result1'
            Console.WriteLine("\nHey! Your first number was " + userNum1 + ". \nMultiply that by 2 and you get " + result1);
            Console.WriteLine(); // added for readability. serves no other function.
            
            
            int result2 = math.maths(userNum2); //assigns object to 'result2'
            Console.WriteLine("Your second number was " + userNum2 + ". \nAdd 6.5 to that and you get " + result2);
            Console.WriteLine(); // added for readability. serves no other function.

            
            int result3 = math.maths(userNum3); //assigns object to 'result2'
            Console.WriteLine("Finally, your third number was " + userNum3 + ". \nSubtract 2 from that and you get " + result3);
            Console.WriteLine(); // added for readability. serves no other function.

            Console.ReadLine();


        }
    }
}
