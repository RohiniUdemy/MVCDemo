using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployessLibrary.BusinessLogic;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            EmployeeManager.DeleteEmployee(id);
            return RedirectToAction("Employees");
        }

        // GET: Employee
        public ActionResult Employees()
        {
            var data = EmployeeManager.GetEmployees();
            List<Employee> employeesList = new List<Employee>();
            foreach (var employee in data)
            {
                employeesList.Add(new Employee()
                {
                    employeeId = employee.EmployeeId,
                    employeeName = employee.EmployeeName,
                    age = employee.Age,
                    email = employee.Email,
                    confirmEmail = employee.Email
                });
            }

            return View(employeesList);
        }


        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Employee emp)
        {
            if (ModelState.IsValid)
            {
                EmployeeManager.AddEmployee(emp.employeeId, emp.employeeName, emp.age, emp.email);
                return RedirectToAction("Employees");
            }
            return View(emp);

        }
        

    }
}