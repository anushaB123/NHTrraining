using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongUsingFunction
{
    internal class Program
    {
        public static bool IsArmstrong(int n)
        {
            int m, rem, result = 0;
            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem * rem * rem;
            }
           return (result==n) ? true : false;
            
        }
        static void Main(string[] args)
        {
            //variable declaratin
            int n, rem, m, result = 0;

            //read the data from user
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            if (IsArmstrong(n))
                 Console.WriteLine("{0} is Armstrong number", n);
            else
                 Console.WriteLine("{0} is not a Armstrong number", n);

            Console.ReadLine();
        }
    }
}
