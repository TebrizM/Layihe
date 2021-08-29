using System;
using Layihe.Enums;
using Layihe.Models;

namespace Layihe
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;
            Department department = new Department("dasdasfd", 10, 300);
            Department.AddDepartment(department);

            Department department2 = new Department("afs", 12, 400);
            Department.AddDepartment(department2);

            Department.GetDepartments();

            Department.EditDepartaments("afs", "SAD");
            Department.GetDepartments();

            Employee employee = new Employee("Musa", Positiontype.IT, 6000, department2.DepartmentName);

            Department.AddEmployee(employee);
            Employee employee1 = new Employee("Tebriz", Positiontype.IT, 6000, department2.DepartmentName);
            Department.AddEmployee(employee1);
            Department.RemoveEmployee("Tebriz");
        }
    }
}
