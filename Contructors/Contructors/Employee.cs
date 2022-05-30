using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{
    public class Employee
    {
        public Employee(string name) : this(name, "Designation 51.52")
        {
        }
        public Employee(string name, string lname)
        {
            Name = name;
            Alt = lname;
        }
        public string Name { get; set; }
        public string Alt { get; set; }

        public void Welcome()
        {
            Console.WriteLine("Welcome {0} {1}!", Name, Alt);
        }
            
    }
}
