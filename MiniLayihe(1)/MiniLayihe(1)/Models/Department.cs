using System;
using System.Collections.Generic;
using System.Text;
using MiniLayihe_1_.Services;
using MiniLayihe_1_.Interfaces;


namespace MiniLayihe_1_.Models
{
    class Department
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
            if (workerlimit >= 1)
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
    }
}
