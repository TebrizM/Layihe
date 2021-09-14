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
        //Everything about Emplyoee
        #region Employee
        //Method for Adding Employee to the Department
        public void AddEmployee(string fullname, Position position, int salary, int departmentindex)
        {
            Department department = _departments[departmentindex];

            Employee employee = new Employee(fullname, position, salary, department);
            department.AddEmployye(employee);
            Console.WriteLine("Employee is added to the Department!");

          
        }
        //Method for Removing Employee from  Department
        public void RemoveEmployee(string depname, string workerno, string workername)
        {
            throw new NotImplementedException();
        }


        //Method for Editing Employee in the Department
        public void EditEmployee(string no, double salary, Position position)
        {
            throw new NotImplementedException();
        }
        #endregion

        //Everything about Department
        #region Department
        //Method for Adding new Department
        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Department department = new Department(name, workerlimit, salarylimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments [ _departments.Length - 1 ] = department;
            Console.WriteLine("Department added Successfully :");
        }
        //Method for Editing Department
        public void EditDepartment(string oldname, string newname)
        {
            foreach (Department item in Departments)
            {
                if(item.Name == oldname)
                {

                item.Name = newname;
                Console.WriteLine("Editing is Completed!");
                
                }
                else
                {
                    Console.WriteLine("No Such Department:");
                }
            }
        }
        //Method for Getting Department
        public Department[] GetDepartments()
        {
            return _departments;

        }
            #endregion
 
    }
}
