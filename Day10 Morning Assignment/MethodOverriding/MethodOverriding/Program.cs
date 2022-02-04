using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class EnglishMessage
    {
        public void PrintHi()
        { 
        
            Console.WriteLine("Hi");
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }
    class TeluguMessage : EnglishMessage
    {
      
        public new void PrintGM()
        {
            Console.WriteLine("Subodhayam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguMessage tm = new TeluguMessage();
            tm.PrintGM();
            tm.PrintHi();
            tm.PrintHello();
            Console.ReadLine();
        }
    }
}
