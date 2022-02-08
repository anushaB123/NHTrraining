using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ 
    class Bank
    {
        public int accno;
        public string accname;
        public int accbalance;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bank> bank = new List<Bank>()
            {
                new Bank(){accno=1011,accname="Satish",accbalance=500},
                new Bank(){accno=1022,accname="Pardhu",accbalance=900},
                new Bank(){accno=1253,accname="Teju",accbalance=600},
                new Bank(){accno=4563,accname="deepu",accbalance=550}
            };

            //for loop
            for(int i=1;i< bank.Count;i++)
            {
                if (bank[i].accbalance > 500)

                    Console.WriteLine(bank[i].accname);
            }

            //foreach loop
            foreach(var s in bank)
            {
                if(s.accbalance>500)
                Console.WriteLine(s.accname);
            }

            //Lambda Expression
            bank.Where(s=>s.accbalance>500).ToList().ForEach(s => Console.WriteLine(s.accname));

            //LINQ Query
            var result=from s in bank
                       where s.accbalance>500
                       select s;
            result.ToList().ForEach(s => Console.WriteLine(s.accname));
            Console.ReadLine(); 
        }
    }
}
