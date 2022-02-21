using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutParameters
{
   internal class Program
    {
        public static string NextNameByRef(ref int id)
        {
            string returnText = "Next-" + id.ToString(); id += 1;
            return returnText;
        }

        public static string NextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString(); return returnText;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n  -----------****  Ref  Keyword  Output  **** 	");

            int i = 1;
            Console.WriteLine("Previous  value  of  integer  i  :  " + i.ToString()); string testRef = NextNameByRef(ref i);
            Console.WriteLine("Current  value  of  integer  i  :  " + i.ToString()); Console.WriteLine("\n  -----------****  Out  Keyword  Output  **** 	");
            int j;
            string testOut = NextNameByOut(out j); Console.WriteLine("Current  value  of  integer  j:" + j.ToString());

            Console.ReadKey();
        }

    }
}

