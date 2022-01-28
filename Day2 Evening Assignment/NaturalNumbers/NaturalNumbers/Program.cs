using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, sum = 0,i;

            //read the data from user
            Console.WriteLine("{Enter the Number:");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for(i=1;i<=input;i++)
            {
                sum = sum + i;
                
            }

            //print output
            Console.WriteLine("sum="+sum);
            Console.ReadLine();
        }
    }
}
