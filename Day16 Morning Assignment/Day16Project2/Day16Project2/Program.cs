using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnushaLibrary;

namespace Day16Project2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m=new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());

            Chemistry c = new Chemistry();
            Console.WriteLine(c.GetBenzene());
            Console.WriteLine(c.GetWater());
            Console.WriteLine(c.GetMethane());

            Console.WriteLine("Final velocity is:");
            Physics.FinalVelocity(2, 3, 4);
          

            Console.ReadLine();

        }
    }
}
