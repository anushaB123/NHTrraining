using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int i, input, count = 0;

            //read the data from user
            Console.WriteLine("Enter any number:");
          input=Convert.ToInt32(Console.ReadLine());

            //logic
            for (i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }

            //print output
            if(count==2)
                   Console.WriteLine("{0} is Prime Number",input);
            else
                   Console.WriteLine("{0} is Not a Prime Number",input);
                Console.ReadLine();

         }
            
     }
}



