using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            //To Do Validations

            var result = EmployeeDAL.AddEmployee(empid, empname, empsalary, empage);
            return result;
        }
        public static List<string> GetEmployeeById(int empid)
        {
            var result = EmployeeDAL.GetEmployeeById(empid);
            return result;
        }
        public static List<string> GetEmployeeByName(string empname)
        {
            var result = EmployeeDAL.GetEmployeeByName(empname);
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }

    }
}
