using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberUsingFunction
{
    
    internal class Program
    {
        public static bool isPrimenumber(int input)
        {
            int i;
            for (i = 2; i < input; i++)
                if (input % i == 0)
                    break;
            if (i == input)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {

            //read the data from user
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            

            //print output
            if (isPrimenumber(n))
                Console.WriteLine("{0} is Prime Number", n);
            else
                Console.WriteLine("{0} is Not a Prime Number",n);
            Console.ReadLine();
        }
    }
}
