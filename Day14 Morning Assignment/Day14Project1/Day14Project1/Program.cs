using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 11,j;
            for (j = 2; j < n; j++)
            {
                if (n % j == 0)
                    break;
            }
            if(j==n)
            {
                Console.WriteLine("{0} is Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number",n);
            }
            Console.ReadLine();
        }
    }
}
