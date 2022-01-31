using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = 1;
            int b = a;
            long c = b;
            float d = c;
            double e = d;

            int f = 23;
            long g = f;
            double h = g;
            
            long i = 30;
            float j = i;
            double k = j;

            float l = 10.0f;
            double m = l;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);   
            Console.WriteLine(e);   


            Console.WriteLine(f);   
            Console.WriteLine(g);   
            Console.WriteLine(h);   
            Console.WriteLine(i);   
            Console.WriteLine(j);   
            Console.WriteLine(k);   
            Console.WriteLine(l);   
            Console.WriteLine(m);
            Console.ReadLine();

        }
    }
}
