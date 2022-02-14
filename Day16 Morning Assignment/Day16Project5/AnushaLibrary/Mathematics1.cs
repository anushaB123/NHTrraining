using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnushaLibrary
{
    public static partial class Mathematics1
    {
        public static int Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        public static int Subtraction(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine(diff);
            return diff;
        }
        public static int Multiplication(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine(mul);
            return mul;
        }
        public static int Division(int a, int b)
        {
            int div = a / b;
            Console.WriteLine(div);
            return div;
        }
    }
}
