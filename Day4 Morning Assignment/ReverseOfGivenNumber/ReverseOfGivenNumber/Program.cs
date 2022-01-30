using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOfGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int n, m, rev = 0, rem;

            //read the data from user
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            //logic
            m = n;
            while(m>0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine("Reverse of {0} is {1}",n, rev);
            Console.ReadLine();
        }
    }
}
