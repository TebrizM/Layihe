using System;
using System.Collections.Generic;
using System.Text;
using Layihe.Enums;
using Layihe.Models;

namespace Layihe
{
    class Employee
    {
        public string No;
        public string Fullname;
        public Positiontype Position;
        public int Salary;
        public string DepartmentName;
        
       


        public Employee(string fullname, Positiontype position, int salary,
            string departmentName)
        {
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;

            
            
        }
    }
}
