using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongRange
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
            return (result == n) ? true : false;

        }
        static void Main(string[] args)
        {
            int a, b, i;
            Console.WriteLine("Enter first number:");
            a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());

            for(i=a; i<=b; i++)
            {
                if(IsArmstrong(i))

                    Console.WriteLine(i);
                   
            }
            Console.ReadLine();
        }
    }
}
