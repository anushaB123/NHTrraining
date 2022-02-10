using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 67, 52, 13 }, { 23, 42, 78 }, { 32, 12, 89 } };
            int sum = 0;
            Console.WriteLine("\n Given Array is : \n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + data[i, j] + " ");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum = sum + data[i, j];
                    }
                }
            }
            Console.WriteLine("\n The Trace of a given array is : {0}", sum);
            Console.ReadLine();

        }
    }
}
