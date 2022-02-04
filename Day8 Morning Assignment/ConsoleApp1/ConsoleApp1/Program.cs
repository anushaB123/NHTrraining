using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 45, 56, 78, 89, 90, 24, 12, 18 };

            //Even numbers using for loop
            for(int i=0; i<data.Count; i++)
            {
                if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }

            //Even numbers using foreach loop
            foreach (var d in data)
            {
                if (d % 2 == 0)
                    Console.WriteLine(d);
            }

            //Even numbers using lambda expression
            data.Where(d=>d%2==0).ToList().ForEach(d => Console.WriteLine(d));

            //Even numbers using Linq
            var result=from d in data
                       where d%2==0
                       select d;
           result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();

        }
    }
}
