using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable assignments

            Console.WriteLine("What is your age?\n(number input only)");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(); // line spaces for readability
            
            Console.WriteLine("How many DUI's do you have?\n(number input only)");
            int dui = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
           
            Console.WriteLine("How many speeding tickets do you have?\n(number input only)");
            int tickets = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Do you qualify for a license?");
            Console.WriteLine(age > 15 && dui <= 0 && tickets <= 3);


            Console.ReadLine();

            //Practice Code:

            //Console.WriteLine(true && false); //both must be true
            //Console.WriteLine(true && true); 
            //Console.WriteLine(true || true);  //either must be true
            //Console.WriteLine(true || false);
            //Console.WriteLine(true == false);
            //Console.WriteLine(true != false);
            //Console.WriteLine(true ^ false); // will read true if ONE variable is true, but not both
        }
    }
}
