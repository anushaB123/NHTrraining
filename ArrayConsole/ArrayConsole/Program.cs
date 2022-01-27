using System;

namespace ArrayConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int sum = 0,avg=0;
            int[] data = new int[5];

            //Read data from user
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //logic
            for(int i = 0;i < data.Length;i++)
            {
                 sum = sum + data[i]; 
                 avg=sum / data.Length;
            }

            //print output
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("avg=" + avg);
            Console.ReadLine();

        }
    }
}
