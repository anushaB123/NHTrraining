using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linearsearch
{
    class Searching
    {
        public static int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        internal class Program
        {
       
            static void Main(string[] args)
             {
                int[] arr = { 10, 50, 30, 70, 80, 60, 20, 90, 40 };
                int x = 20;

                // Function call
                int result = search(arr, x);
                if (result == -1)
                    Console.WriteLine("Element is not present in array");
                else
                    Console.WriteLine("Element is present at index " + result);
                Console.ReadLine();
            }
        }
    }
}
