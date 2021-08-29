using System;
using System.Collections.Generic;
using System.Text;
using Layihe.Enums;
using Layihe.Models;



namespace Layihe.Models
{
    class Department : IHumanResourceManager
    {
        
        public string DepartmentName;
        public int WorkerLimit;
        public int SalaryLimit;
        public string Employees;
        public int SalaryAverage;
        public static Employee[] Employee = new Employee[0];
       

        public Department(string departmentName, int workerlimit, int salarylimit)
        {
            this.DepartmentName = departmentName;
            if(workerlimit >= 1)
            {
                this.WorkerLimit = workerlimit;
            }
            else
            {
                Console.WriteLine("Invalid Worker Limit! Limit has to set to 1");
                this.WorkerLimit = 1;
            }
            if (salarylimit >= 250)
            {
                this.SalaryLimit = salarylimit;
            }
            else
            {
                Console.WriteLine("Invalid Salary Limit! Limit has to set to 250");
                this.SalaryLimit = 250;
            }



          
            
        }

        public static Department[] departament = new Department[0];

        
        public static void AddDepartment(Department department)
        {
            Array.Resize(ref departament, departament.Length + 1);
            departament[departament.Length - 1] = department;
   
        }

        public static void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employee, Employee.Length + 1);
            Employee[Employee.Length - 1] = employee;
        }

        public static void EditDepartaments(string name, string newname)
        {
            if (Array.Exists(departament, e => e.DepartmentName == name))
            {
                foreach (var item in departament)
                {
                    if(item.DepartmentName == name)
                    {
                        item.DepartmentName = newname;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not Such Department Found!");
            }
        
        }

        public void EditEmploye()
        {
            
        }

        public static void GetDepartments()
        {
            foreach (var item in departament)
            {
                Console.WriteLine($"Name : {item.DepartmentName} Worker Limit : {item.WorkerLimit} Salary Limit : {item.SalaryLimit}" );
            }
        }

        public static void RemoveEmployee(string name)
        {
            if(Array.Exists(Employee, e=>e.Fullname == name)) 
            {
                Employee = Array.FindAll(Employee, e => e.Fullname != name);
                foreach (var item in Employee)
                {
                    Console.WriteLine($"{item.Fullname}");
                }
            }
            else
            {
                Console.WriteLine("No Such Employee Found");
            }

            
        }
    }
}
