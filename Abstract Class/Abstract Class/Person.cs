using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Person //Abstract class 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName(); //Sayname is required for all child classes
    }
}
