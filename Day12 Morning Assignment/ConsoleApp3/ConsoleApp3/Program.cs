using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter first number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b=Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }


    }
}
