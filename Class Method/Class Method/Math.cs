using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    public class Math
    {
        //Divide Method
        public static void div(int userNum1)
        {
            Console.WriteLine(userNum1 / 2);
        }
       
        // Overload Methods
        public int maths(int userNum1)
        {
            int sum = userNum1 + 2;
            return sum;
        }
        // Overload Methods
        public int maths(int userNum1, int userNum2)
        {
            int sum = userNum1 + 2 * userNum2;
            return sum;
        }
        
        // Out Method
        public void output(out int userNum1)
        {
            userNum1 = 2;
        }
    }
}
