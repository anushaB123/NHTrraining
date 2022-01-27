using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialusingFunctions
{
    internal class Program
    {
        //purpose to read a number and print its factorial
        int Factorial(int input);

        static void Main(string[] args)
        {
            //variable declaration
            int fn, sn;


            //read the data from user
            Console.WriteLine("enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            //print the output
            Console.WriteLine("Factorial of {0} is {1}", fn, Factorial(fn));
            Console.WriteLine("Factorial of {0} is {1}", sn, Factorial(sn));
            Console.ReadLine();

            int Factorial(int input)
            {

                int fact = 1;
                for (int i = 0; i < input; i++)
                {
                    fact = fact * i;
                    return fact;
                }

            }
        }
        
    }
}



   

