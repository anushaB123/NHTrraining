using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int sum = 0;
            int[] data = new int[5];

            //Read data from user
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //logic
            foreach(int d in data)
            {
                sum = sum + d;
            }

            //print output
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();
        }
    }
}
