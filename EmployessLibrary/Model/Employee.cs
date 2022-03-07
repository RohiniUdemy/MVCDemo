using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployessLibrary.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public String EmployeeName { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }
    }
}
