using System;

namespace HumanResources
{
    public class Employee : Staff, ICalculator
    {
        public int OverTime { get; set; }
        public override double Salary
        {
            get
            {
                return CalculateSalary();
            }
        }

        public double CalculateSalary()
        {
            return SalaryRate * Constants.BasicSalary + OverTime * Constants.SalaryHour;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("Employee Information");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            //Console.WriteLine("Department: " + Department.Name);
            Console.WriteLine("Date of join: " + DateOfJoin);
            Console.WriteLine("Vacation: " + Vacation);
            Console.WriteLine("Overtime: " + OverTime);
            Console.WriteLine("SalaryRate: " + SalaryRate);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("---------------------------");
        }

        public override void InputStaff()
        {
            base.InputStaff();

            int overTime;
            do
            {
                Console.Write("Input overtime: ");
            } while (!int.TryParse(Console.ReadLine(), out overTime));
            OverTime = overTime;
        }
    }
}
