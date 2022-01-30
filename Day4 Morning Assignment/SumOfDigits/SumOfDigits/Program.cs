using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int n, m, i, rem, result = 0;

            //read the data from user
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            //logic
            m = n;
            while(m>0)
            {
                rem = m % 10;
                m = m / 10;
                result = result+ rem;
            }

            Console.WriteLine("Sum of digits {0} is {1}", n, result);
            Console.ReadLine();
        }
    }
}
