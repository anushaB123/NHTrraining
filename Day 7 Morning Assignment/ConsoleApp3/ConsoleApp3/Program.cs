using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product
    {
        private int id;
        private string name;
        private string brand;
        
        public void ReadProduct()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name =Console.ReadLine();

            Console.WriteLine("Enter brand:");
            brand = Console.ReadLine();
        }
        public void PrintProduct()
        {
            Console.WriteLine("Id={0},Name={1},Brand={2}",id,name,brand);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Product p = new Product();
            p.ReadProduct();
            p.PrintProduct();
            Console.ReadLine();
        }
    }
}
   