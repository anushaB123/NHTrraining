using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplemented
{
    class Student
    {
        // Auto-implimented Properties  
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // Setting properties  
            student.ID = 101;
            student.Name = "Anusha Bellala";
            student.Email = "Anu@example.com";
            // Getting properties  
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Email);
            Console.ReadLine();

        }
    }
}
       
