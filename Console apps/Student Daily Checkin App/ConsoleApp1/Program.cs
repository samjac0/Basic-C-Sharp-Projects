using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is the start to a daily checkin report for students. The next programmer can utiliaze the variables below for further use.
            // "\n" provides line breaks for readability.
           
            Console.WriteLine("Powered by the tech academy. \nStudent Daily Report. \n \n");
            
            
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //NOTE! data type = integer32
            Console.WriteLine("\n\nWhat page number?");
            int yourPage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nWhat course are you on?");
            string yourCourse = Console.ReadLine();

            //NOTE! data type = boolean
            Console.WriteLine("\n\nDo you need help with anything? Please answer 'true' or 'false.'");
            string yourHelpA = Console.ReadLine();
            bool myBool = yourHelpA == "true";

            Console.WriteLine("\n\nWere there any positive experiences you’d like to share? Please give specifics.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("\n\nIs there any other feedback you’d like to provide? Please be specific.");
            string yourHurtfulFeedback = Console.ReadLine();

            //NOTE! data type = integer32
            Console.WriteLine("\n\nHow many hours did you study today?");
            int yourHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");


        }
    }
}
