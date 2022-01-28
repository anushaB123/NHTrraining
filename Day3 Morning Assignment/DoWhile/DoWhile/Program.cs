using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Anusha Bellala");
                Console.WriteLine("Do want to print again(y/n):");
                str = Console.ReadLine();
            }
            while (str == "y");
            Console.ReadLine();
        }
    }
}
