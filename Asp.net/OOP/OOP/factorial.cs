using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class factorial
    {
        public int number { get; set; }

        public int factorialNumber(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            return number*factorialNumber(number-1);
        }
    }
}
