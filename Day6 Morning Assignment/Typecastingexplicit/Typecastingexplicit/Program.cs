using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecastingexplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            short b = (short)a;

            double d = 13.7d;
            float f = (float)d;
            long l =(long) d;
            int i = (int)d;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(f);   
            Console.WriteLine(l);   
            Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
