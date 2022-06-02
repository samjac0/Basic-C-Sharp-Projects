using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class Math
    {
        public int maths(int userNum1)
        {
            return userNum1 * 2;
        }

        public int maths(decimal userNum2)
        {
            return Convert.ToInt32(userNum2 + 6.5m);
        }

        public int maths(string userNum3)
        {
            return Convert.ToInt32(userNum3) - 2;
        }
    }
}
