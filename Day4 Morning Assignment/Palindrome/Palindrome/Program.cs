using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //variable declaration
            int n, m, rem, rev = 0;

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
            if (n == rev)
                Console.WriteLine("{0} is a Palindrome", n);
            else
                Console.WriteLine("{0} is not a Palindrome",n);
            Console.ReadLine();

        }
        
    }
}
