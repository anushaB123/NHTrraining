using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Customer
    {
        private int id;
        private string name;
        private int age;
        public void ReadCustomer()
        {

            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());



        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Id={id},Name={name},Age={age}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.ReadCustomer();
            c.PrintCustomer();
            Console.ReadLine();
        }
    }
}
