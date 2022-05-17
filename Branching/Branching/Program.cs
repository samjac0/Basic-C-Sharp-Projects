using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.");
            Console.WriteLine(); // used for spacing
            
            Console.WriteLine("Please enter the package weight; using only numbers and kilograms");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width, in centimeters");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height, in centimeters");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length, in centimeters");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); // used for spacing

            int packageSize = width + height + length;
            int packageCost = (width * height * length) * weight / 100;

            string result = packageSize <= 50 ? "Your box meets all requirements and the estimate shipping cost is $" + packageCost.ToString() : "We are sorry, but your package is too large for shipment.";
            Console.WriteLine(result);

            Console.ReadLine();


            // excercises below:
            //int cTemp = 70;
            //int rTemp = 70;

            //if (cTemp == rTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (cTemp > rTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            //Console.ReadLine();
        }
    }
}
