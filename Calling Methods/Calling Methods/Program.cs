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
            double userNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nLast, type a whole number OR decimal. ");
            string userNum3a = Console.ReadLine();
            double userNum3b = Double.Parse(userNum3a);  

            var multiplicationObject = new Math(); //Creates a new multiplication object to be imported from Math.cs
            var result1 = multiplicationObject.multiplication(userNum1); //assigns object to 'result1'
            Console.WriteLine("\nHey! Your first number was " + userNum1 + ". \nMultiply that by 2 and you get " + result1);
            Console.WriteLine(); // added for readability. serves no other function.
            
            var addObject = new Math();//Creates a new add object to be imported from Math.cs
            var result2 = addObject.add(userNum2); //assigns object to 'result2'
            Console.WriteLine("Your second number was " + userNum2 + ". \nAdd 6.5 to that and you get " + result2);
            Console.WriteLine(); // added for readability. serves no other function.

            var subObject = new Math();//Creates a new add object to be imported from Math.cs
            var result3 = subObject.sub(userNum3b); //assigns object to 'result2'
            Console.WriteLine("Finally, your third number was " + userNum3b + ". \nSubtract 2 from that and you get " + result3);
            Console.WriteLine(); // added for readability. serves no other function.

            Console.ReadLine();


        }
    }
}
