using System;
using Finaltry.Enum;
using Finaltry.Interface;
using Finaltry.Models;
using Finaltry.Service;

namespace Finaltry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling our Method
            Runmthd();
        }
        static void Runmthd()
        {
            //Changes color of the all texts
            Console.ForegroundColor = ConsoleColor.Yellow;
            HumanManagerService humanManagerService = new HumanManagerService();


            //Creating our Welcomming Page
            Console.WriteLine(@"
                                                 _     _                              _  _         
   | | _  |  _  _ __  _    _|_ _    _|_|_  _    | \ _ |_) _  ___|___  _ __ _|_    _ _|__|_ o  _  _ 
   |^|(/_ | (_ (_)|||(/_    |_(_)    |_| |(/_   |_/(/_|  (_| |  |_|||(/_| | |_   (_) |  |  | (_ (/_
");

            byte choice;

            //variables to store user inputs and create objects;
            string name;
            int workerlimit;
            int salarylimit;

            // Used for Editing Department
            string oldDepartmentname;
            string newDepartmentname;

            //Editing variables;
            string editID;
            bool isFound = false;


            string typestr;
            int typeint;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Creating out Menu
                Console.Write("                                            << 1: Show Department >> \n                                            << 2: Add Department >> \n                                            << 3: Edit Department >> \n                                            << 4: Add employeee >> \n                                            << 5: Edit Employee >> \n                                            << 6: Remove Employee >> \n                                            << 7: Get Employee Data >> \n                                            << 0: Exit >>");
                Console.WriteLine();
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    #region CASE 1
                    case 1:
                        //Showing Information about Departments
                        foreach (var item in humanManagerService.GetDepartments())
                        {
                            Console.WriteLine($"Department Name: {item.Name} | Worker Limit: {item.WorkerLimit} | Salary Limit: {item.SalaryLimit}");

                        }

                        break;
                    #endregion
                    #region CASE 2
                    case 2:
                        //Gathering user input
                        Console.Write("                                                Department Name: ");
                        name = Console.ReadLine();
                        Console.Write("                                                Worker Limit: ");
                        workerlimit = Convert.ToInt32(Console.ReadLine());
                        Console.Write("                                                Salary Limit: ");
                        salarylimit = Convert.ToInt32(Console.ReadLine());

                        //Creating object based on user input
                        Department department = new Department(name, workerlimit, salarylimit);

                        //Calling our Add Department method and passing the newly created object
                        humanManagerService.AddDepartment(name, workerlimit, salarylimit);
                        break;
                    #endregion
                    #region CASE 3
                    case 3:
                        //Method for Editing Department
                        Console.WriteLine("                                                Enter Department Name: ");
                        oldDepartmentname = Console.ReadLine();
                        Console.WriteLine("                                                New Department Name: ");
                        newDepartmentname = Console.ReadLine();

                        humanManagerService.EditDepartment(oldDepartmentname, newDepartmentname);

                        break;
                    #endregion
                    #region CASE 4
                    case 4:
                        // Method for add new employee
                        Console.Write("                        Employee's Name and Surname :");
                        string fullname = Console.ReadLine();

                        for (int j = 0; j < humanManagerService.Departments.Length; j++)
                        {
                            Console.WriteLine($"{j + 1} - {humanManagerService.Departments[j].Name}");
                        }
                        int dprtInt = int.Parse(Console.ReadLine());
                        string[] positiontype = Position.GetNames(typeof(Position));
                        for (int i = 0; i < positiontype.Length; i++)
                        {
                            Console.WriteLine($"{i + 1} - {positiontype[i]}");
                        }


                        Console.WriteLine("                        Position:");
                        typestr = Console.ReadLine();
                        while (!int.TryParse(typestr, out typeint) || typeint < 1 || typeint > positiontype.Length)
                        {
                            Console.WriteLine("                        Try Again : ");
                            typestr = Console.ReadLine();

                        }
                        Position enums = (Position)typeint;


                    tryagain:
                        Console.WriteLine("                        Salary: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        if (salary <= 250)
                        {
                            Console.WriteLine("                        Invalid Salary Limit! Limit has to set to 250");
                            goto tryagain;
                        }

                        humanManagerService.AddEmployee(fullname, enums, salary, (dprtInt - 1));
                        break;
                    #endregion
                    #region CASE 5
                    case 5:
                        //Method for make change on employee
                        Console.Write("Search Employee: ");
                        editID = Console.ReadLine();
                        foreach (var item in humanManagerService.GetDepartments())
                        {
                            for (int i = 0; i < item.Employees.Length; i++)
                            {

                                if (editID == item.Employees[i].No)
                                {
                                    Console.WriteLine($"Employee's Name: {item.Employees[i].FullName} Employee's Salary: {item.Employees[i].Salary} Employee's Position {item.Employees[i].Position}");

                                    for (int a = 0; a < Position.GetNames(typeof(Position)).Length; a++)
                                    {
                                        Console.WriteLine($"{a + 1} - { Position.GetNames(typeof(Position))[a]}");
                                    }

                                    Console.WriteLine("                        Position:");
                                    typestr = Console.ReadLine();
                                    while (!int.TryParse(typestr, out typeint) || typeint < 1 || typeint > Position.GetNames(typeof(Position)).Length)
                                    {
                                        Console.WriteLine("                        Try Again : ");
                                        typestr = Console.ReadLine();

                                    }
                                    enums = (Position)typeint;

                                    item.Employees[i].Position = enums;



                                    Console.WriteLine("                        Salary: ");
                                    salary = Convert.ToInt32(Console.ReadLine());
                                    while (salary <= 250)
                                    {
                                        Console.WriteLine("                        Invalid Salary Limit! Limit has to set to 250");

                                        Console.WriteLine("                        Salary: ");
                                        salary = Convert.ToInt32(Console.ReadLine());

                                    }
                                    item.Employees[i].Salary = salary;

                                    isFound = true;
                                    break;
                                }

                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("No Such Employee: ");
                            isFound = false;

                        }

                        break;
                    #endregion
                    #region CASE 6
                    case 6:
                        //Method for Removing employee
                        Console.Write("Search Employee: ");
                        editID = Console.ReadLine();
                        foreach (var item in humanManagerService.GetDepartments())
                        {
                            for (int i = 0; i < item.Employees.Length; i++)
                            {

                                if (editID == item.Employees[i].No)
                                {
                                    Console.WriteLine($"Employee's Name: {item.Employees[i].FullName} Employee's Salary: {item.Employees[i].Salary} Employee's Position {item.Employees[i].Position}");

                                    for (int a = 0; a < Position.GetNames(typeof(Position)).Length; a++)
                                    {
                                        Console.WriteLine($"{a + 1} - { Position.GetNames(typeof(Position))[a]}");
                                    }
                                    Console.WriteLine("Employee Deleted: ");
                                    item.Employees[i] = item.Employees[item.Employees.Length - 1];
                                    Array.Resize(ref item.Employees, item.Employees.Length - 1);
                                    isFound = true;

                                }
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("Not Such Employee");
                            isFound = false;

                        }
                        break;

                    #endregion
                    #region CASE 7
                    case 7:
                        //Method for Showing employee's info
                        foreach (var department1 in humanManagerService.GetDepartments())
                        {
                            Console.WriteLine($"\n {department1.Name} \n");
                            foreach (var employee in department1.Employees)
                            {
                                Console.WriteLine($"{employee.No}  {employee.FullName}  {employee.Salary} {employee.Position}");
                            }
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    #endregion
                    #region  CASE 8
                    case 0:
                        Console.WriteLine("                                                Program Terminated");
                        break;
                    #endregion
                    #region  CASE 9
                    default:
                        Console.WriteLine("                                                Invalid Option!");
                        break;
                        #endregion
                }

            }
            while (choice != 0);
        }
    }
}
