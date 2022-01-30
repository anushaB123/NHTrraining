using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number of rows :");
            int rows=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*");
                }

                Console.WriteLine("\n");

                
            }
                 Console.ReadKey();
        }
    }
}
