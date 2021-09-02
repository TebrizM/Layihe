using System;
using System.Collections.Generic;
using System.Text;
using Finaltry.Enum;
using Finaltry.Interface;
using Finaltry.Service;

namespace Finaltry.Models
{
    class Department
    {
        public string Name;
        public int WorkerLimit;
        public double SalaryLimit;
        public Employee[] Employees;

        public Department(string name, int workerlimit, double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new Employee[0];

            if (workerlimit >= 1)
            {
                WorkerLimit = workerlimit;
            }
            else
            {
                Console.WriteLine("Invalid Worker Limit! Limit has to set to 1");
                this.WorkerLimit = 1;
            }
            if (salarylimit >= 250)
            {
                SalaryLimit = salarylimit;
            }
            else
            {
                Console.WriteLine("Invalid Salary Limit! Limit has to set to 250");
                SalaryLimit = 250;
            }
        }
        // Method for Resize Array
        public void AddEmployye(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;

        }
        // Method for Avarage Salary
        public double CalcSum()
        {
            double sum = 0;
            foreach (var item in Employees)
            {
                sum += item.Salary;
            }
            double average = sum / Employees.Length;
            return average;
        }
    }
    
}
