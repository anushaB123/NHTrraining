using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Seller
    {
        public int id;
        public string name; 
        public string emailid;
        public void ReadSeller()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter emailid:");
            emailid= Console.ReadLine();
        }
        public void PrintSeller()
        {
            Console.WriteLine($"Id={id},Name={name},Emailid={emailid}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Seller s = new Seller();    
            s.ReadSeller();
            s.PrintSeller();
            Console.ReadLine();
        }
    }
}
