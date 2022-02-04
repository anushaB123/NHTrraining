using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){id=101,name="Anu",salary=5000},
                new Employee(){id=102, name="Madhuri",salary=7000},
                new Employee(){id =103,name="Nandu",salary =8000},
                new Employee(){id =104,name="Sindhu",salary=4500},
                new Employee(){id=105,name ="Prem",salary=4000}
            };

            //for loop
            for(int i = 0; i < employees.Count; i++)
            {
                if(employees[i].salary>5000)
                    Console.WriteLine(employees[i].name);
            }

            //foreach loop
            foreach(var e in employees)
            {
                Console.WriteLine(e.name);
            }

            //Lambda Expression
            employees.Where(e => e.salary>5000).ToList().ForEach(e => Console.WriteLine(e.name));

            //LINQ Query
            var result=from e in employees
                       where e.salary>5000
                       select e.name;

            result.ToList().ForEach(e => Console.WriteLine(e));
            Console.ReadLine();
        }
    }
}
