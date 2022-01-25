using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powernumConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pow = 1,fn,sn;
            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=sn;i++)
            {
                pow = pow * fn;
            }
            Console.WriteLine("p="+pow);
            Console.ReadLine();
        }
    }
}
