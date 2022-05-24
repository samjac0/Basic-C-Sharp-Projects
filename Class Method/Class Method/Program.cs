using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this fun little program featuring Methods!\nEnter a number to get started.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWant to add another number to the mix? If not, leave blank and press enter.");
            int userNum2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nHere's your first number below. It was divided by 2 using a static class method from 'Math.cs':");

            Math.div(userNum1);

            Console.WriteLine("\nHere's and example of an Overload Method");
            Math obj1 = new Math();
            Console.WriteLine(obj1.maths(userNum1));
            Console.WriteLine(obj1.maths(userNum1, userNum2));
            
            Console.WriteLine("\nHere's an example of an Out method");
            obj1.output(out userNum1);
            Console.WriteLine(userNum1);


            Console.ReadLine();


        }
    }
}
