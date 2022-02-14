using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Poject3
{
    class MultiplicationTable
    {
        int input;

        public int ReadInput()
        {

            Console.Write("\n Enter any Number To Print its Multiplication Table : ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n::: Displaying the Multiplication Table for {0} :::\n", input);
            return input;
        }

        public void PrintMulTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                //Printing OutPut using String Formating
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }

            Console.WriteLine();
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                
                MultiplicationTable table = new MultiplicationTable();
                table.ReadInput();      
                table.PrintMulTable();  

                Console.ReadKey();
            }
        }
    }
}
