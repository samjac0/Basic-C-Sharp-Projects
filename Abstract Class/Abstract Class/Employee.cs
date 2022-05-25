using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
        public int Employee_ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // define SayName for employee class
        }

        public void Quit()
        {
            {
                Console.WriteLine("This program has now ended");
            }
        }
    }
}
