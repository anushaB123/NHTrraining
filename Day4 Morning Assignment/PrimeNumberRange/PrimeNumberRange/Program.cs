using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, str, end, ctr, num;

            //read the data from user

            Console.WriteLine("Enter starting number:");
            str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number:");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", str, end);



            //logic
            for (num = str; num <= end; num++)
            {

                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }

                }
                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.ReadLine();
        }
    }  
}

