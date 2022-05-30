using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Hello, and welcome to this simple program.");

            Console.WriteLine("The date and time at your location is currently {0}.", now);

            Console.WriteLine("Now, please select how many hours you wish to add to the current time.");
            int userHours = Convert.ToInt32(Console.ReadLine());


            DateTime later = now.AddHours(userHours);

            Console.WriteLine("In {0} hours, the time and date will be exactly {1}.", userHours, later );
            

            Console.ReadLine();
        }
    }
}
