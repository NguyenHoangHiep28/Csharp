using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class HumanResourceManagement
    {
        private List<Staff> employees;
        private List<Department> departments = new List<Department>
        {
            new Department(){ Id=1,Name="Marketing"},
            new Department(){ Id=2,Name="HR"},
            new Department(){ Id=3,Name="Academic"},
        };

        public HumanResourceManagement()
        {
            employees = new List<Staff>();
        }

        public void AddStafff()
        {
            Console.WriteLine("Input staff Information");
            Console.WriteLine("1. Input emloyee information");
            Console.WriteLine("2. Input Manager information");

            int choice;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out choice));

            Staff staff;

            switch (choice)
            {
                case 1:
                    staff = new Employee();
                    break;
                case 2:
                    staff = new Manager();
                    break;
                default:
                    staff = new Employee();
                    break;
            }

            staff.InputStaff();
            employees.Add(staff);
        }

        public void DisplayAllStaff()
        {
            foreach (var staff in employees)
            {
                staff.DisplayInformation();
            }
        }

        public void DisplayAllEmployee()
        {
            foreach (var staff in employees)
            {
                if (staff is Employee)
                {
                    staff.DisplayInformation();
                }

            }
        }

        public void DisplayAllManager()
        {
            foreach (var staff in employees)
            {
                if (staff is Manager)
                {
                    staff.DisplayInformation();
                }

            }
        }

        public Staff SearchByName(string name)
        {
           
            foreach (var staff in employees)
            {
                if (staff.Name.Equals(name))
                {
                    return staff;
                }
            }
            return null;
        }
        public Staff SearchById(int Id)
        {
            foreach (var staff in employees)
            {
                if(staff.Id == Id)
                {
                    return staff;
                }
            }
            return null;
        }

        public void DisplaySalaryTable()
        {
            Console.WriteLine("Name\t\tSalary\n" +
                              "----\t\t------");
            foreach (var staff in employees)
            {
                Console.WriteLine($"{staff.Name}\t{staff.Salary}");
            }
        }

        public void DisplayAscendingSalaryTable()
        {
            employees.Sort((X, y) => X.Salary.CompareTo(y.Salary));
            Console.WriteLine("Name\t\tSalary\n" +
                              "----\t\t------");
            foreach (var staff in employees)
            {
                Console.WriteLine($"{staff.Name}\t{staff.Salary}");
            }
        }
    }
}
