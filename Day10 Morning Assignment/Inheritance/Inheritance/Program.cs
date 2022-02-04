using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Algebra
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
    }
    class TotalMaths : Algebra
    {
       
        public int Mul(int a,int b)
        {
            return a* b;
        }
    }
    class AllSubjects : TotalMaths
    {
        public string Methane()
        {
            return"CH4";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AllSubjects obj=new AllSubjects();
            Console.WriteLine (obj.Add(4, 5));
            Console.WriteLine(obj.Sub(9,7));
            Console.WriteLine(obj.Mul(6,8));
            Console.WriteLine(obj.Methane());
            Console.ReadLine();
        }
    }
}
