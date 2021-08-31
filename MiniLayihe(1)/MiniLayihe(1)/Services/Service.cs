using System;
using System.Collections.Generic;
using System.Text;
using MiniLayihe_1_.Interfaces;
using MiniLayihe_1_.Models;


namespace MiniLayihe_1_.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        public static Department[] departament = new Department[0];
        public static Employee[] Employee = new Employee[0];

        public void ListofDepartments(Department department)
        {
            foreach (Department item in departament)
            {
                Console.WriteLine("List is Created!");
            }
        }

        public void AddDepartment(Department department)
        {
            Array.Resize(ref departament, departament.Length + 1);
            departament[departament.Length - 1] = department;

        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employee, Employee.Length + 1);
            Employee[Employee.Length - 1] = employee;
        }

        public void EditDepartaments(string name, string newname)
        {
            if (Array.Exists(departament, e => e.DepartmentName == name))
            {
                foreach (var item in departament)
                {
                    if (item.DepartmentName == name)
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

        public void EditEmploye(string name, string newname)
        {
            if(Array.Exists(Employee, a => a.Fullname == name))
                foreach (var item in Employee)
                {
                    if (item.Fullname == name)
                    {
                        item.Fullname = newname;
                    }
                }
            else
            {
                Console.WriteLine("Not Such Employee Found!");
            }
        }

        public void GetDepartments()
        {
            foreach (var item in departament)
            {
                Console.WriteLine($"Name : {item.DepartmentName} Worker Limit : {item.WorkerLimit} Salary Limit : {item.SalaryLimit}");
            }
        }

        public static void RemoveEmployee(string name)
        {
            if (Array.Exists(Employee, e => e.Fullname == name))
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
