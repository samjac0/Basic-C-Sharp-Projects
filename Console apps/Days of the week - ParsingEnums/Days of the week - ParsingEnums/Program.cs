using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_of_the_week___ParsingEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a day of the week");

            try
            {
                string userDay = Console.ReadLine();

                Day day = (Day)Enum.Parse(typeof(Day), userDay, true); //true = case insensitive

                Console.WriteLine("Just to re-interate, you chose " + day + "!");

            }

            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again and check your spelling.");
            }
            finally
            {
                Console.WriteLine("This program has finished.");
            }

            Console.ReadLine();
        }
    }
}
