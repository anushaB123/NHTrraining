using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSecondMethodConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, i;

            //read the data from user
            Console.WriteLine("{Enter the Number:");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }

            //print output
            Console.ReadLine();
        }
    }
}