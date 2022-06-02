using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{
    public class Employee
    {
        public Employee(string name) : this(name, 2160)
        {
            Console.WriteLine("Name is " + name + " and your default pay would be " + Num);
        }

        public Employee(float pay) : this("Robot", pay)
        {
            Console.WriteLine("Default pay is " + pay + " and your default name is " + Name );
        }
        public Employee(string name, float pay)
        {
            Name = name;
            Num = pay;

        }
        public string Name { get; set; }
        public float Num { get; set; }

    }
}
