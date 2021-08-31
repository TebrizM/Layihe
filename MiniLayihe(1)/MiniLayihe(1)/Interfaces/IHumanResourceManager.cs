using System;
using System.Collections.Generic;
using System.Text;
using MiniLayihe_1_.Models;
using MiniLayihe_1_.Services;

namespace MiniLayihe_1_.Interfaces
{
    interface IHumanResourceManager
    {
        public static Department[] departament = new Department[0];
        public static Employee[] Employee = new Employee[0];

        public void AddDepartment(Department department);



        public void GetDepartments();




        public void EditDepartaments(string name, string newname);
        

        
        public static void AddEmployee(Employee employee)
        {

        }
        public static void RemoveEmployee(string name)
        {

        }
        public static void EditEmploye(string name, string newname)
        {

        }
    }
}
