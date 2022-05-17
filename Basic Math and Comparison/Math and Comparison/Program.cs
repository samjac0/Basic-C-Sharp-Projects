using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison");
            
            Console.WriteLine("Person 1 \nHours worked?");
            int Hours1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hourly rate of pay? (number input only)");
            int Hourly1 = Convert.ToInt16(Console.ReadLine());
           
            Console.WriteLine("\n\nNow, let's move on to our second person. \nHours worked for person 2?");
            int Hours2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hourly rate of pay? (number input only)");
            int Hourly2 = Convert.ToInt16(Console.ReadLine());

            int SalaryP1 = Hours1 * Hourly1 * 52;
            int SalaryP2 = Hours2 * Hourly2 * 52;
            
            Console.WriteLine();
            Console.WriteLine("Person 1's yearly salary is " + SalaryP1.ToString());
            Console.WriteLine("Person 2's yearly salary is " + SalaryP2.ToString());
            
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            
            bool money = SalaryP1 > SalaryP2;
            Console.WriteLine(money);



            Console.ReadLine();




            // excersises below
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine(difference);

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 72;

            //bool isWarm = currentTemperature >= roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //bool isWarm = currentTemperature == roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();
        }
    }
}
