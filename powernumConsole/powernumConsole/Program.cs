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
            //variable declaration
            int pow = 1,fn,sn;

            //read the data from user
            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            //logic
            for (int i=1;i<=sn;i++)
            {
                pow = pow * fn;
            }

            //print output
            Console.WriteLine("p="+pow);
            Console.ReadLine();
        }
    }
}
