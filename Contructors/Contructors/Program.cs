using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string prize = " 3 skittles. ";
            Console.WriteLine("Hello! Welcome to this simple program. Would you submit your first name or robotic designation number?");
            var id = Console.ReadLine();
            //Console.WriteLine("Great! Now input your last name if you would like. Or, just hit 'Enter'");
            //var pay = Console.ReadLine();

            if (float.TryParse(id, out float id2))
            {
                Employee employee = new Employee(id2);
                Console.WriteLine("You also get" + prize +"Awesome!");


            }
            else
            {
                Employee employee = new Employee(id);
                Console.WriteLine("You also get" + prize + "Great Work!");
            }
           
            Console.ReadLine();
        }
    }
}
