using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Mathematics
    {
        public static int add(int a,int b)
        {
            return a + b;
        }
        public static int div(int a, int b)
        {
            return a/b;    
        }
        public static int mul(int a,int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.add(5,7));
            Console.WriteLine(Mathematics.div(9,5));
            Console.WriteLine(Mathematics.mul(5,6));
            Console.ReadLine();

        }
    }
}
