using System;

namespace HumanResources
{
    public class Manager : Staff, ICalculator
    {
        public Position Position { get; set; }

        public override double Salary
        {
            get
            {
                return CalculateSalary();
            }
        }

        public double CalculateSalary()
        {
            double salaryResponsibility = 0;

            switch (Position)
            {
                case Position.BusinessLeader:
                    salaryResponsibility = 8_000_000;
                    break;
                case Position.ProjectLeader:
                    salaryResponsibility = 5_000_000;
                    break;
                case Position.TechnicalLeader:
                    salaryResponsibility = 6_000_000;
                    break;
            }

            return SalaryRate * 5_000_000 + salaryResponsibility;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("Manger Information");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            //Console.WriteLine("Department: " + Department.Name);
            Console.WriteLine("Date of join: " + DateOfJoin);
            Console.WriteLine("Vacation: " + Vacation);
            Console.WriteLine("Position: " + Position.ToString());
            Console.WriteLine("SalaryRate: " + SalaryRate);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("---------------------------");
        }

        public override void InputStaff()
        {
            base.InputStaff();
            
            Console.WriteLine("Manager position : ");
            Console.WriteLine("1. " + Position.BusinessLeader.ToString());
            Console.WriteLine("2. " + Position.ProjectLeader.ToString());
            Console.WriteLine("3. "+ Position.TechnicalLeader.ToString());

            int position;
            do
            {
                Console.Write("Input manager position: ");
            } while (!int.TryParse(Console.ReadLine(),out position));
            Position =(Position)( position);
        }
    }
}
