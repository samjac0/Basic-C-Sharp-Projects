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
            Console.WriteLine("Welcome to this fun little program featuring Methods!\nEnter any number to send it through multiple mathmatical methods");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            var multiplicationObject = new Math(); //Creates a new multiplication object to be imported from Math.cs
            var result1 = multiplicationObject.multiplication(userNum1); //assigns object to 'result1'
            Console.WriteLine("Hey! Your number multiplied by 2 is " + result1);
            Console.WriteLine(); // added for readability. serves no other function.
            
            var addObject = new Math();//Creates a new add object to be imported from Math.cs
            var result2 = addObject.add(userNum1); //assigns object to 'result2'
            Console.WriteLine("Or, add 6 and you get " + result2);
            Console.WriteLine(); // added for readability. serves no other function.

            var subObject = new Math();//Creates a new add object to be imported from Math.cs
            var result3 = subObject.sub(userNum1); //assigns object to 'result2'
            Console.WriteLine("Finally, if you subtract 6, you get " + result3);

            Console.ReadLine();


        }
    }
}
