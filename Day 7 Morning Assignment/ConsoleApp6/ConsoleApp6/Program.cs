using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){id=1,name="anu",salary=4500},
                new Employee(){id=2,name="madhu",salary=5000},
                new Employee(){id=3,name="prem",salary=6000},
                new Employee(){id=4,name="sindhu",salary=8000},
                new Employee(){id =5,name="vyshu",salary=3000}
            };

            //for loop
            for (int i = 0; i < employees.Length; i++)
            {
                if(employees[i].salary>=5000)
                Console.WriteLine($"Id={employees[i].id},Name={employees[i].name},Salary={employees[i].salary}");
            }

            //foreach loop
            foreach (var e in employees)
            {
                if(e.salary>=5000)
                Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}");
            }

            //Lambda Expression
            employees.ToList().Where(e=>e.salary>=5000).ToList().ForEach(e => Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}"));
            


            Console.ReadLine();
        }
    }
}
