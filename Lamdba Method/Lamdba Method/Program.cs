using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdba_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Employee> employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, fname = "Joe", lname = "Shmoe the 1st" },
                new Employee() { Id = 2, fname = "Joe", lname = "Shmoe the 2nd" },
                new Employee() { Id = 3, fname = "Joe", lname = "Shmoe the 3rd" },
                new Employee() { Id = 4, fname = "Joe", lname = "Shmoe the 4th" },
                new Employee() { Id = 5, fname = "Bob", lname = "Gilbert" },
                new Employee() { Id = 6, fname = "Jill", lname = "Jackson" },
                new Employee() { Id = 7, fname = "Laura", lname = "Elleby" },
                new Employee() { Id = 8, fname = "Lisa", lname = "Scrivens" },
                new Employee() { Id = 9, fname = "Jack", lname = "Jackson" },
                new Employee() { Id = 10, fname = "John", lname = "Doe" },
            };


            Console.WriteLine("This list below displays all employees in a list with the first name 'Joe' using a 'foreach' loop:");
            List<Employee> employees = new List<Employee>();
            foreach (Employee item in employeeList)
            {
                if (item.fname == "Joe")
                {
                    employees.Add(item);
                    Console.WriteLine(item.fname + " " + item.lname);
                }


            }

            Console.WriteLine("\nThis list below displays all employees in a list with the first name 'Joe' using a 'lambda' expression:");
            List<Employee> employees1 = employeeList.Where(x => x.fname == "Joe").ToList();
            foreach (Employee item1 in employees1)
            {
                Console.WriteLine(item1.fname + " " + item1.lname);
            }


            Console.WriteLine("\nThis list below displays all employees in a list with an 'Id' greater than '5' using the 'lambda' expression:");
            List<Employee> employees2 = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee item2 in employees2)
            {
                Console.WriteLine(item2.fname + " " + item2.lname);
            }


            Console.ReadLine();
        }

    }
}
