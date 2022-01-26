using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumberConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, i, product = 1;

            //read data from the user
            Console.WriteLine("Enter the Number:");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for(i=1;i<=input;i++)
            {
                product = product * i;
            }

            //print output
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
