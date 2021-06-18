using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManagement management = new HumanResourceManagement();
            do
            {
                Console.WriteLine("1. Input staff information");
                Console.WriteLine("2. Display all staffs");
                Console.WriteLine("3. Display all employees");
                Console.WriteLine("4. Display all managers");
                Console.WriteLine("5. Search staff information");
                Console.WriteLine("6. Display salary table");
                Console.WriteLine("7. Display ascending salary table");
                Console.WriteLine("0. Exit");
                int choice = -1;

                do
                {
                    Console.Write("Enter your choice: ");
                } while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                        management.AddStafff();
                        break;
                    case 2:
                        management.DisplayAllStaff();
                        break;
                    case 3:
                        management.DisplayAllEmployee();
                        break;
                    case 4:
                        management.DisplayAllManager();
                        break;
                    case 5:
                        int searchOption;
                        do
                        {
                            Console.WriteLine("\t1. Search by Name.");
                            Console.WriteLine("\t2. Search by Id.");
                            Console.Write("Choose an option: ");
                        } while (!int.TryParse(Console.ReadLine(), out searchOption));
                        switch (searchOption)
                        {
                            case 1:
                                Console.WriteLine("Enter staff name: ");
                                string name = Console.ReadLine();
                                var staffFound = management.SearchByName(name);
                                if (staffFound != null)
                                {
                                    staffFound.DisplayInformation();
                                }
                                else
                                {
                                    Console.WriteLine($"Cannot find staff name \"{name}\" !");
                                }
                                break;
                            case 2:
                                int id;
                                do
                                {
                                    Console.WriteLine("Enter id: ");
                                } while (!int.TryParse(Console.ReadLine(), out id));
                                var result = management.SearchById(id);
                                if (result != null)
                                {
                                    result.DisplayInformation();
                                }
                                else
                                {
                                    Console.WriteLine($"Cannot find staff id \"{id}\" !");
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid search option is chosen. Please choose again!");
                                break;
                        }

                        break;
                    case 6:
                        management.DisplaySalaryTable();
                        break;
                    case 7:
                        management.DisplayAscendingSalaryTable();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Reenter!");
                        break;
                }
            } while (true);
        }
    }
}
