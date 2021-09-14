using System;
using System.Collections.Generic;
using System.Text;
using Finaltry.Enum;
using Finaltry.Models;
using Finaltry.Service;

namespace Finaltry.Interface
{
    interface IHumanResourceManager
    {
        // Department array
        Department[] Departments { get; }
        
        //Method for Adding Department
        public void AddDepartment(string name, int workerlimit, double salarylimit); 

        //For Editing Department
        public void EditDepartment(string oldname, string newname); 
        // Method for Adding Employee
        public void AddEmployee(string fullname, Position position, int salary, int departmentindex); 
        //Method for Removing Employee
        public void RemoveEmployee(string depname, string workerno, string workername); 

        //For Editing Employee
        public void EditEmployee(string no, double salary, Position position);
        // For Getting Department
        public Department[] GetDepartments(); 
    }
}
