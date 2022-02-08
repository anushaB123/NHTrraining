using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        
        public int Salary
        {
            get
            {
                return  (Designation == "S") ? 30000 : 60000;
                
              
            }

        }
        public string Designation { get; set; }
        

            
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 10;
            emp.Name = "anu";
            emp.Designation = "M";

            Console.WriteLine("Enter id:{0}",emp.Id);
            Console.WriteLine("Enter name:{0}", emp.Name);
            
            Console.WriteLine("designation:{0}", emp.Designation);
            Console.WriteLine("salary:{0} ", emp.Salary);
            Console.ReadLine();
        }
    }
}
