using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

        public Employee()
        {
            id = 0;
            name = null;
            salary = 0;
        }

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        /// <summary>
        /// Read data from user
        /// </summary>
        public void ReadData()
        {

            Console.WriteLine("Enter Employee id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Print data
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Id={id},Name={name},Salary={salary},Company={company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1,"siddu",8000);
            emp1.PrintData();
            Employee emp2 = new Employee();
            emp2.PrintData();
            
            
            Console.ReadLine();
        }
    }
}
