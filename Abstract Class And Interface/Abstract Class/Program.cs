using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Employee_ID = 1;
            
            Employee employee2 = new Employee();
            employee2.Employee_ID = 2;

            //Console.WriteLine(employee == employee2); //Bool statements. Removed to keep "False" from showing up from program without any context.
            //Console.WriteLine(employee != employee2); //Bool statements. Removed to keep "True" from showing up from program without any context.


            employee.SayName();

            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
