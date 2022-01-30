using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumberWithOutUsingThirdVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 8;
            Console.WriteLine("Before Swap;\n");
            Console.WriteLine("a={0},b={1}",a,b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swap:\n");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.ReadLine();
        }
    }
}
