using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnushLibrary;
using PublicLibrary;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Factorial(5));
            Console.WriteLine(Physics.FinalVelocity(5, 5, 5));
             Console.ReadLine();
        }
    }
}
