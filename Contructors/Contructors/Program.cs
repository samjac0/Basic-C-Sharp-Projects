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
            Console.WriteLine("Hello! Welcome to this simple program. Would you submit your first name or robotic designation number?");
            var name = Console.ReadLine();
            Console.WriteLine("Great! Now input your last name if you would like. Or, just hit 'Enter'");
            var lname = Console.ReadLine();

            try
            {
                Employee employee = new Employee(name, lname);
                employee.Welcome();
            }
            catch
            {
                Employee employee = new Employee(name);
                employee.Welcome();
            }
           
            Console.ReadLine();
        }
    }
}
