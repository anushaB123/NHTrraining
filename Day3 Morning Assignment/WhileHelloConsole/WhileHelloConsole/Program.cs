using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileHelloConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine("Hello\n");
                i++;
            }
            Console.ReadLine(); 
        }
    }
}
