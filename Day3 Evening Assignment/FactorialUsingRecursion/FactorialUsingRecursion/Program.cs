using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialUsingRecursion
{
    internal class Program
    {
        //read a number and print factorial[using recursion]

        static void Main(string[] args)
        {

            //variable declaration
            int fn, sn;
            


            //read the data from user
            Console.WriteLine("enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());
            int fact = Factorial(fn);
            int fact1 = Factorial(sn);

            //print the output
            Console.WriteLine("Factorial of {0} is {1}", fn,fact);
            Console.WriteLine("Factorial of {0} is {1}", sn, fact1);
            Console.ReadLine();
        }
                private static int Factorial(int input)
            {
                
                if (input == 0)
                        return 1;
                    else
                        return input * Factorial(input - 1);
                
            }

        
    }
}
