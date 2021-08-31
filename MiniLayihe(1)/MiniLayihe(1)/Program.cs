using System;
using MiniLayihe_1_.Enums;
using MiniLayihe_1_.Interfaces;
using MiniLayihe_1_.Models;
using MiniLayihe_1_.Services;


namespace MiniLayihe_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            HumanResourceManager humanResourceManager = new HumanResourceManager();


            do
            {
                Console.WriteLine("                                                       Welcome to the Department Office");
                Console.WriteLine("                                               -------------------------------------------");
                Console.WriteLine("                                                           1.1 Show All Departments");
                Console.WriteLine("                                                           1.2 Add Department");
                Console.WriteLine("                                                           1.3 Edit Department");
                Console.WriteLine("                                                           2.1 Show All Employees");
                Console.WriteLine("                                                           2.2 Add Employee");
                Console.WriteLine("                                                           2.3 Edit Employee");
                Console.WriteLine("                                                           2.4 Remove Employee");
                Console.WriteLine("                                                -------------------------------------------");
                string pick = Console.ReadLine();

                int choose;
                while (!int.TryParse(pick, out choose))
                {
                    Console.WriteLine("                                                           Duzgun Daxil Edin!");
                    pick = Console.ReadLine();
                    int.TryParse(pick, out choose);
                }

                switch (choose)
                {
                    case 1:
                        ListofDepartments(humanResourceManager);
                        break;
                    case 2:

                    case 3:
                        AddEmployee( humanResourceManager);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Seciminiz Sehvdir!");
                        break;
                }

            } while (true);
        }

        public static void ListofDepartments(HumanResourceManager humanResourceManager)
        {
            Console.WriteLine("Departamentler");
            foreach (var item in Enum.GetValues(typeof(Positiontype)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            Console.WriteLine("Departamentleri Secin:");
            string positionty = Console.ReadLine();
            int positionNum;
            while (!int.TryParse(positionty, out positionNum))
            {
                Console.WriteLine("                                                         Departament Nomresini Duzgun Daxil Edin!");
                positionty = Console.ReadLine();
                int.TryParse(positionty, out positionNum);

            }

            Console.WriteLine("");


        }


        public static void AddEmployee( HumanResourceManager humanResourceManager)
        {
            string name;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            string surname;
            Console.WriteLine("Enter Surname: ");
            surname = Console.ReadLine();

            byte age;
            bool ageCheck;
            Console.WriteLine("Enter Age: ");
            Console.ReadKey();
            ageCheck = Byte.TryParse(Console.ReadLine(), out age);
            if (!ageCheck)
            {
                Console.WriteLine("Wrong Age!");
                age = 0;
            }
            Console.ReadKey();

        }
    }
}
    

