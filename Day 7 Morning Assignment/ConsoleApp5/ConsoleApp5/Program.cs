using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Department
    {
        public int id;
        public string name;
        public int staff;  
     
        public void ReadDepartment()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name of department:");
            name = Console.ReadLine();

            Console.WriteLine("Enter no. of staff in the department:");
            staff =Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDepartment()
        {
            Console.WriteLine($"Id={id},Name={name},Staff={staff}");
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department();   
            d.ReadDepartment();
            d.PrintDepartment();
            Console.ReadLine();
        }
    }
}
