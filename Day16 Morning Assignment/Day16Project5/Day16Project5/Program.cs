using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnushaLibrary;

namespace Day16Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Executing Mathematical Operations Using Partial Class \n");

            Console.Write("\nAddition of 5 & 6 is : ");
            Mathematics1.Addition(5, 6);
            Console.Write("\nSubtraction of 7 & 3 is : ");
            Mathematics1.Subtraction(7, 3);
            Console.Write("\nMultiplication of 8 & 4 is : ");
            Mathematics1.Multiplication(8, 4);
            Console.Write("\nDivision of 9 / 5 is : ");
            Mathematics1.Division(9, 5);

            Console.WriteLine("\n Factorial of 5 is : {0}", Mathematics2.Factorial(5));

            Console.ReadKey();
        }
    }
}
