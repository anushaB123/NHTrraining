using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[4][];
            names[0] = new char[] { 'A', 'N', 'U', 'S', 'H', 'A' };
            names[1] = new char[] { 'M', 'A', 'D', 'H', 'U', 'R','I' };
            names[2] = new char[] { 'P', 'R', 'E', 'M' };
            names[3] = new char[] { 'S', 'I', 'N', 'D', 'U'};
            // Printing The Jagged Array Values.
            Console.WriteLine("\n  Jagged Array Of Names \n");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine("\n");
                Console.ReadLine();
            }
        }

    }
}

