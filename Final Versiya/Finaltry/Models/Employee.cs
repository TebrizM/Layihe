using System;
using System.Collections.Generic;
using System.Text;
using Finaltry.Enum;
using Finaltry.Interface;
using Finaltry.Service;

namespace Finaltry.Models
{
    class Employee
    {
        //Variables for Employees
        private static int _no = 1000;
        public string No;
        public string FullName;
        public Position Position;
        public double Salary;
        public string DepartmentName;

        public Employee(string fullname, Position position, int salary, Department departmentname)
        {
            _no++;
            FullName = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname.Name;
            No = departmentname.Name.Substring(0, 2).ToUpper() + _no;
        }
    }
}
