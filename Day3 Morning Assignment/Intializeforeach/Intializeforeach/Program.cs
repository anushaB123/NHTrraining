using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intializeforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration

            int[] data = new int[] { 2, 3, 4, 5, 6 };
            for(int i=0; i<data.Length; i++)
            {
                Console.WriteLine(data[i]); 
            }
            Console.ReadLine();    

        
        }
    }
}
