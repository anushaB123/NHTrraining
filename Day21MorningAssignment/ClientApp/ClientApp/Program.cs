using ClientApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine($"Addition={obj.Add(4,5)}");
            Console.WriteLine($"Mutiplication={obj.Mul(6,7)}");
            Console.WriteLine($"Division={obj.Div(30,5)}");
            Console.WriteLine(obj.Factorial(5));

            Console.ReadLine();

        }
    }
}
