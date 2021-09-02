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
            Runmthd();
        }
        static void Runmthd()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            HumanManagerService humanManagerService = new HumanManagerService();



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
            //variables for employee
            string fullname;
            string departmentname;
            Position position;
            double salary;
            //for editing Employee
            string id;
            double esalary;
            //Positiontype positions;
            string[] positionsName;
            //string removingemployee;
            string removingemployee;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("                                            << 1: Get Department >> \n                                            << 2: Add Department >> \n                                            << 3: Edit Department >> \n                                            << 4: Add Employee >> \n                                            << 5: Edit Employee >> \n                                            << 6: Remove Employee >> \n                                            << 7: Get Employee Data >> \n                                            << 0: Exit >>");
                Console.WriteLine();
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    #region CASE 1
                    case 1:
                        humanManagerService.GetDepartments();
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
                        Console.WriteLine("                                                Enter Department Name: ");
                        oldDepartmentname = Console.ReadLine();
                        Console.WriteLine("                                                New Department Name: ");
                        newDepartmentname = Console.ReadLine();

                        humanManagerService.EditDepartment(oldDepartmentname, newDepartmentname);

                        break;
                    #endregion
                    #region CASE 4
                    case 4:
                       
                        break;
                    #endregion
                    #region CASE 5
                    case 5:
                       
                        break;
                    #endregion
                    #region CASE 6
                    case 6:

                        break;
                    #endregion
                    #region CASE 7
                    case 7:
                        
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
