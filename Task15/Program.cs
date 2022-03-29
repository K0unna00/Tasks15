using System;
using ClassLibrary;

namespace Task15
{
    internal class Program
    {
        static void Main()
        {
            Department department = new Department();
            department.EmployeeLimit = 1;
            Employee employee = new Employee();

            employee.Name = "Salammmm";
            employee.Name = "dsdsdsdsd";
            employee.Surname = "Sadsdsddsd";
            employee.Surname = "dsdsdsdsd";

            department.AddEmployee(employee);
            foreach (var item in department.employees)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
        }
    }
}