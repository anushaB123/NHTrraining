using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MathTask
    {
        private int a;
        private int b;
        public void ReadData()
        {
            Console.WriteLine("Enter first number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b=Convert.ToInt32(Console.ReadLine());
        }
        public int AddNumbers()
        {
            return a+b;
        }
        public int SubNumbers()
        {
            return a- b;
        }
        public int MultiplyNumbers()
        {
            return a * b;
        }
        public int DivisionNumbers()
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTask obj=new MathTask();
            obj.ReadData();
            Console.WriteLine(obj.AddNumbers());
            Console.WriteLine(obj.SubNumbers());
            Console.WriteLine(obj.MultiplyNumbers());
            Console.WriteLine(obj.DivisionNumbers());
            Console.ReadLine();
        }
    }
}
