using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int n, i, a = 0, b = 1,c;
            
            //read the data from user
            Console.WriteLine("Enter no. of terms to be printed(n>2):");
           n=Convert.ToInt32(Console.ReadLine());
            

            //logic
            Console.WriteLine("Fibonacci series: 0 1");
            for(i=1;i<=n-2;i++)
            {
                c = a + b;
                
                a = b;
                b = c;
                Console.WriteLine("c="+c);
            }
            Console.ReadLine(); 
        }
    }
}
