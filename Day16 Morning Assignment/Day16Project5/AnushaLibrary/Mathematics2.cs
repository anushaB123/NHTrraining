using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnushaLibrary
{
    public static partial class Mathematics2
    {
        public static int Factorial(int input)
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
