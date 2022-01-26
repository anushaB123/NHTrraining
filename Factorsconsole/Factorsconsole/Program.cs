using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorsconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, i;

            //read the data from user
            Console.WriteLine("Enter the Number:");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for(i=1;i<=input;i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
            //print output
            Console.ReadLine();
        }
    }
}
