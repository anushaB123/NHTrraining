using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Algebra a = new Algebra();
            Console.WriteLine(a.Add(1, 2));
            Console.WriteLine(a.Add(2, 3, 4));
            Console.WriteLine(a.Add(3, 4, 5, 6));
            Console.ReadLine();

        }
    }
}
