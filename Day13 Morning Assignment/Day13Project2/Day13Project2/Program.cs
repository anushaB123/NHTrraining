using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 23, 46 }, { 15, 76 }, { 47, 80 } };

            Console.WriteLine("\n Enter 2-D Array Representation for declaring in same line \n");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.Write("\n");
                Console.ReadLine();
            }

        }
    }
}
