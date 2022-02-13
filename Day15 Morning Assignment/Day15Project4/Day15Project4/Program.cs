using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are Creating a File using streamWriter Class. It will not over Ride Each time when we run the code.
            // Instead it will Append the Text of Lines, Each time We Run the Code.
            StreamWriter writer = new StreamWriter(@"F:\c# programs\Day15 Morning Assignment\StreamWriterAppendExample.txt", true);

            writer.WriteLine("This is From New object of Stream Writer,");
            writer.WriteLine("using Append by assigning True, while creating object for StreamWriter");

            writer.Close();
            Console.WriteLine("\n Appending is done, by using Stream Writer Class, By Enabling Append Method(true).");

            // We Are Reading the File Content using Stream Writer Class From System.IO namespace.
            StreamReader reader = new StreamReader(@"F:\c# programs\Day15 Morning Assignment\StreamWriterAppendExample.txt");

            reader.ReadToEnd();

            reader.Close();
            Console.WriteLine("\n Reading is done, by using Stream Writer Class, by ReadToEnd Method.");

            Console.ReadKey();

        }
    }
}
