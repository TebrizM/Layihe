using System;
using System.Collections.Generic;
using System.Text;
using MiniLayihe_1_.Services;
using MiniLayihe_1_.Interfaces;
using MiniLayihe_1_.Enums;

namespace MiniLayihe_1_.Models
{
    class Employee
    {
        private static int Count = 1000;
        public string No;
        public string Fullname;
        public string Position;
        public int Salary;
        public string DepartmentName;
        public Positiontype positiontype;




        public Employee(string fullname, int salary,
            string departmentName, Positiontype positiontype)
        {
            Fullname = fullname;
            
            Salary = salary;
            DepartmentName = departmentName;

            Count++;

            switch (positiontype)
            {
                case Positiontype.IT:
                    No = "IT" + Count;
                    break;
                case Positiontype.HR:
                    No = "HR" + Count;
                    break;
                case Positiontype.Sales:
                    No = "SA" + Count;
                    break;
                case Positiontype.Accounting:
                    No = "ACC" + Count;
                    break;
                case Positiontype.Management:
                    No = "MA" + Count;
                    break;
                default:
                    break;
            }
        }
    }
}
