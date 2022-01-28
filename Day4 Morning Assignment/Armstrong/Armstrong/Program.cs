using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rem, m, result = 0;
            Console.WriteLine("Enter any number:");
           n=Convert.ToInt32 (Console.ReadLine());

            m = n;
            while(m>0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem * rem * rem;
            }
            if(result==n)
                Console.WriteLine("{0} is Armstrong number",n);
            else
                Console.WriteLine("{0} is not a armstrong number",n);
            Console.ReadLine();

        }
           
     }
}

