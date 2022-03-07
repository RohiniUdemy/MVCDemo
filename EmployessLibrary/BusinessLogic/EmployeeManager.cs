using EmployessLibrary.DataAccess;
using EmployessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployessLibrary.BusinessLogic
{
    public static class EmployeeManager
    {
        public static int AddEmployee(int EmloyeeId, String EmployeeName, int Age, String Email)
        {
            Employee emp = new Employee
            {
                EmployeeId = EmloyeeId,
                EmployeeName = EmployeeName,
                Age = Age,
                Email = Email
            };

            String sql = @"insert into Employees(EmployeeId, EmployeeName, Age, Email) values
                (@EmployeeId, @EmployeeName, @Age, @Email)";
            return SqlDataAccess.SaveData(sql, emp);
        }

        public static List<Employee> GetEmployees()
        {
            String sql = "select EmployeeId, EmployeeName, Age, Email from Employees";
            return SqlDataAccess.LoadModel<Employee>(sql);
        }

        public static int DeleteEmployee(int id)
        {
            String sql = String.Format("delete from Employees where EmployeeId ={0}", id);
            return SqlDataAccess.DeleteData(sql);
        }
    }
}
