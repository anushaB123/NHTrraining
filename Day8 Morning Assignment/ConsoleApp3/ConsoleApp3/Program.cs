using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        { 


          List<Product> products = new List<Product>()
          {
              new Product() { id = 1, name ="Laptop",price =50000, brand ="Dell"},
              new Product() { id = 2, name ="Mobile",price=20000, brand ="Redmi"},
              new Product(){ id = 3, name ="Tv",price=30000,brand ="Samsung"},
              new Product{ id = 4, name ="Washing Machine",price=15000,brand ="LG"}
          };


        //for loop
        for(int i=0;i<products.Count;i++)
            {

                if (products[i].price > 20000)
                    Console.WriteLine($"Name={products[i].name},Brand={products[i].brand}");

            }

        //foreach loop
        foreach(var p in products)
            {
                if(p.price>20000)
                    Console.WriteLine($"Name={p.name},Brand={p.brand}");
            }

        //Lambda Expression
        products.Where(p => p.price>20000).ToList().ForEach(p => Console.WriteLine($"Name={p.name},Brand={p.brand}"));

        //LINQ Query
        var result=from p in products
                   where p.price>20000
                   select p;
            result.ToList().ForEach(p => Console.WriteLine($"Name={p.name},Brand={p.brand}"));
            Console.ReadLine(); 
        }
    }
}
