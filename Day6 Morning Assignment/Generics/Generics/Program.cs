using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data=new List<int>();
            int sum = 0;
            data.Add(5);
            data.Add(10);
            data.Add(20);
            data.Add(50);
            data.Add(70);
            foreach(var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine("sum="+sum);
            Console.ReadLine();
        }
    }
}
