using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(90);
            data.Push(45);
            data.Push(67);
            data.Push(12);
            Console.WriteLine($"The Stack size before removing the last item is : {data.Count}");
            Console.WriteLine($"The Stack item to be removed is : {data.Peek()}");
            Console.WriteLine($"In Stack ,the item removed is : {data.Count}");
            Console.WriteLine($" The Stack size after removing the last item is : {data.Count}");
            Console.WriteLine($"The Stack next item to be removed is: {data.Peek()}");
            Console.ReadLine();

        }
    }
}
