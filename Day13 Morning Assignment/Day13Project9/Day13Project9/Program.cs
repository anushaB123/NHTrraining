using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(22);
            data.Enqueue(43);
            data.Enqueue(90);
            data.Enqueue(67);
            Console.WriteLine($"The Queue size before removing the last item is : {data.Count}");
            Console.WriteLine($"The Queue item to be removed is : {data.Peek()}");
            Console.WriteLine($"In Queue,the item removed is : {data.Dequeue()}");
            Console.WriteLine($" The Queue size after removing the last item is : {data.Count}");
            Console.WriteLine($"The Queue next item to be removed is: {data.Peek()}");
            Console.ReadLine();

        }
    }
}
