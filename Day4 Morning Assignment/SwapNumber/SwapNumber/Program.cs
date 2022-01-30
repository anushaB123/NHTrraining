using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 8, t;
            Console.WriteLine("Before Swap:\n");
            Console.WriteLine("a={0},b={1}", a, b);
            t = a;
            a = b;
            b = t;
            Console.WriteLine("After Swap:\n");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.ReadLine();
        }
        
    }
}
