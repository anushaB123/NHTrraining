using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ 
    class Seller
    {
        public int id;
        public string name;
        public string emailid;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Seller> seller = new List<Seller>()
            {
                new Seller(){id=1,name="Satish",emailid="satish@gmail.com"},
                new Seller(){id=2,name="Pardhu",emailid="pardhu@gmail.com"},
                new Seller(){id=3,name="Teju",emailid ="teju@gmail.com"},
                new Seller(){id=4,name="deepu",emailid="deepu@gmail.com"}
            };

            //for loop
            for(int i=0;i<=seller.Count;i++)
            {
                Console.WriteLine(seller[i]);
            }

            //foreach loop
            foreach(var s in seller)
            {
                Console.WriteLine(s);
            }

            //Lambda Expression
            seller.ForEach(s => Console.WriteLine(s));

            //LINQ Query
            var result=from s in seller
                       where s.emailid=="deepu@gmail.com"
                       select s;
            result.ToList().ForEach(s => Console.WriteLine(s));
            Console.ReadLine(); 
        }
    }
}
