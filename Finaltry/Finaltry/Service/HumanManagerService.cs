using System;
using System.Collections.Generic;
using System.Text;
using Finaltry.Enum;
using Finaltry.Interface;
using Finaltry.Models;

namespace Finaltry.Service
{
    class HumanManagerService : IHumanResourceManager
    {
        private Department[] _departments;
        public Department[] Departments => _departments;
        public HumanManagerService()
        {
            _departments = new Department[0];
        }

        #region Employee
        public void AddEmployee(string fullname, Position position, int salary, int departmentindex)
        {
            Department department = _departments[departmentindex];

            Employee employee = new Employee(fullname, position, salary, department);
            department.AddEmployye(employee);
            Console.WriteLine("Employee is added to the Department!");
            

        }

        public void RemoveEmployee(string depname, string workerno, string workername)
        {
            throw new NotImplementedException();
        }
       


        public void EditEmployee(string no, double salary, Position position)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Department

        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Department department = new Department(name, workerlimit, salarylimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments [ _departments.Length - 1 ] = department;
            Console.WriteLine("Department added Successfully :");
        }

        public void EditDepartment(string oldname, string newname)
        {
            foreach (Department item in Departments)
            {
                item.Name = newname;
                Console.WriteLine("Editing is Completed!");
                return;
            }
        }

        public void GetDepartments()
        {
            foreach (Department item in _departments)
            {
                Console.WriteLine(item);
            }
        }

        public Department[] ShowDepartments()
        {
            return _departments;
        }

        public void InfoDepartment()
        {

            foreach (var item in Departments)
            {
                for (int i = 0; i < Departments.Length; i++)
                {
                    if (item.Employees == null)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"Department Name: {item.Name} || Isci sayi: {item.Employees.Length}  || Ortalama maas : {item.CalcSum()}");
                        break;
                    }
                }
            }
            #endregion

           
   
        }

    }
}
