using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public abstract class BaseEmployee
    {
        protected string employeeId;
        protected string employeeName;
        protected string employeeAddress;

        public abstract string EmployeeId { get; set; }
        public abstract string EmployeeName { get; set; }
        public abstract string EmployeeAddress { get; set; }

        public BaseEmployee(string id, string name, string address)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.EmployeeAddress = address;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1} {2}", employeeId, employeeName, employeeAddress);
        }
        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
