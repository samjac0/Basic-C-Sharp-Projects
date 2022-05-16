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
            
            string P1 = "Person 1 ";
            int HourlyRP1 = 15; // Hourly Rate of person 1
            int HoursP1 = 40; // Hours worked person 1
            int SalaryP1 = 31200;

            string P2 = "Person 2 ";
            int HourlyRP2 = 20;
            int HoursP2 = 15;
            int SalaryP2 = 41600;


            Console.WriteLine("Person 1 worked " + HoursP1.ToString() + " hours");
            Console.WriteLine("Person 1's hourly rate is " + HourlyRP1.ToString());

            Console.WriteLine("Person 2 worked " + HoursP2.ToString() + " hours");
            Console.WriteLine("Person 2's hourly rate is " + HourlyRP2.ToString());
            Console.WriteLine();
            
            Console.WriteLine("Annual salary of person 1 is " + SalaryP1.ToString());
            Console.WriteLine("Annual salary of person 2 is " + SalaryP2.ToString());
            Console.WriteLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            
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
