using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Morning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
              
                Console.WriteLine("Answer={0}", c);
              
                Console.ReadLine();
            }
            catch(OverflowException)
            {
                Console.WriteLine("number should be 0 to 50000 are allowed");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("only numbers are allowed. please double check");
            }
            catch(Exception)
            {
                Console.WriteLine("Any errors will occur contact admin@mycompany.com");
                Console.ReadLine();
            }
            
        }
    }
}
