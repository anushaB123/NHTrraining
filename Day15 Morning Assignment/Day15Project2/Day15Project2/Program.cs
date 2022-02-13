using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\c# programs\Day15 Morning Assignment\Hello.txt";

            string TaskSchedularPath = @"F:\c# programs\TaskSchedularPath.txt";
            if (File.Exists(TaskSchedularPath))
                File.Delete(TaskSchedularPath);

            File.Copy(filePath, TaskSchedularPath);

            Console.WriteLine("File Copying is Done");

            Console.ReadKey();

        }
    }
}
