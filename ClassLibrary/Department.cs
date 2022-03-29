using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        public string Name { get; set; }
        private int _employeeLimit;
        public int EmployeeLimit
        {
            get => _employeeLimit; set
            {
                _employeeLimit = value;
            }
        }
        public int SalaryLimit { get; set; }
        public Employee[] employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            if (employees.Length < EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
        }
    }
}
