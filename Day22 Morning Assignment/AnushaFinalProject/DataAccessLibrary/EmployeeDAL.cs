using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class EmployeeDAL
    {
        public static string filepath = "F:\\c# programs\\EmployeeData\\Employee.txt";


        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            try
            {
                string textContent = String.Concat(empid, ",", empname, ",", empsalary, ",", empage);
                File.AppendAllText(filepath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<string> GetEmployeeById(int empid)
        {
            var allEmployees = File.ReadAllLines(filepath);
           // bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == empid)
                {
                   // isFound = true;
                    employeeFound.Add(employee);
                    break;

                }
            }
            return employeeFound;
        }
        public static List<string> GetEmployeeByName(string empname)
        {
            var allEmployees = File.ReadAllLines(filepath);
            //bool isFound = false;
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(empname))
                {
                    employeeFound.Add(employee);
                }
            }

            return employeeFound;
        }
        public static string[] GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filepath);
            return allEmployees;


        }
    }
}
