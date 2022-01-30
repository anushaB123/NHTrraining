using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialusingFunctions
{
    internal class Program

    {
        int Factorial(int input)
        {
            int fact = 1, i;
            for (i = 1; i <= input; i++)
                fact = fact * i;
            return fact;


        }
        //purpose to read a number and print its factorial

        static void Main(string[] args)
        {
            //variable declaration
            int input, i, fact = 1;
            int input1, fact1 = 1;


            //read the data from user
            Console.WriteLine("enter first number:");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            input1 = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            for (i = 1; i <= input1; i++)
            {
                fact1 = fact1 * i;
            }

            //print the output
            Console.WriteLine("Factorial of {0} is {1}", input, fact);
            Console.WriteLine("Factorial of {0} is {1}", input1, fact1);
            Console.ReadLine();

           



        }
    }

}



   

