using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? firstValue = 10; 
            
            
            int? secondValue = null;

            int? result;
            result = (firstValue.HasValue) ? firstValue : null;
            Console.WriteLine("The  value  inside  First  Value  Nullable  type  is  :  {0}", result);
            result = (secondValue.HasValue) ? secondValue : null; 
            Console.WriteLine("The  value  inside  Second  Value  Nullable  type  is  :  {0}",result);
            

            Console.ReadKey();
        }

    }
}

