using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static object ViewBag { get; private set; }

        static void Main(string[] args)
        {

            StringBuilder stringBuilder = new StringBuilder(17, 17);
            stringBuilder.Append("Welcome to the ");
            
                stringBuilder.Insert(0, "world of C# programming", 1);
                Console.WriteLine(stringBuilder.ToString());
                Console.ReadLine();
            
            
        }
    }
}

    

