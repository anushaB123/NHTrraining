using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Product
    {
        public int id;
        public string name;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(){ id = 1, name ="laptop",brand="dell"},
                new Product(){ id = 2, name ="washingmachine",brand ="LG"},
                new Product(){ id = 3, name ="TV",brand="samsung"},
                new Product(){id = 4, name ="mobile",brand="oneplus"}
            };

            //for loop
            for(int i=0;i<products.Length;i++)
            {

                Console.WriteLine($"Id={products[i].id},Name={products[i].name},Brand={products[i].brand}");
            }

            //foreach loop
            foreach(var p in products)
            {
                Console.WriteLine($"Id={p.id},Name={p.name},Brand={p.brand}");
            }

            //lambda Expression
            products.ToList().ForEach(p => Console.WriteLine($"Id={p.id},Name={p.name},Brand={p.brand}"));
            Console.ReadLine();
                 }
    }
}
