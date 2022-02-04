using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){id = 101,name="Marketing",empcount=50},
                new Department(){id = 102,name="Finance",empcount =30},
                new Department(){id = 103,name="Operations Management",empcount=60},
                new Department(){id = 104,name="Human Resource",empcount=40},
                new Department(){id = 105,name="IT",empcount=20}
            };

            //for loop
            for (int i = 0; i < departments.Count; i++)
            {

                if (departments[i].empcount > 50)

                    Console.WriteLine($"Id={departments[i].id},Name={departments[i].name}");
            }

            //foreach loop
            foreach (var d in departments)
            {
                if (d.empcount > 50)
                    Console.WriteLine($"Id={d.id},Name={d.name}");
            }

            //Lambda Expression
            departments.Where(d => d.empcount > 50).ToList().ForEach(d => Console.WriteLine($"Id={d.id},Name={d.name}"));
       
           //LINQ Query
           var result=from d in departments
                      where d.empcount > 50
                      select d; 
            result.ToList().ForEach(d=>Console.WriteLine($"Id={d.id}, Name={d.name}"));
            Console.ReadLine();

        }
    }
}
