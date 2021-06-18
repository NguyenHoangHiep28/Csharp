using System;

namespace HumanResources
{
    public abstract class Staff 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfJoin { get; set; }
        public int Vacation { get; set; }
        public double SalaryRate { get; set; }
        public abstract void DisplayInformation();
        public abstract double Salary { get; }
        public Department Department { get; set; }

        public virtual void InputStaff()
        {
            int id;
            do
            {
                Console.Write("Input id: ");
            } while (!int.TryParse(Console.ReadLine(), out id));

            Console.Write("Input name: ");
            string name = Console.ReadLine();

            int age;
            do
            {
                Console.Write("Input age: ");
            } while (!int.TryParse(Console.ReadLine(), out age));

            DateTime dateOfJoin;
            do
            {
                Console.Write("Input date of join: ");
            } while (!DateTime.TryParse(Console.ReadLine(), out dateOfJoin));

            int vacation;
            do
            {
                Console.Write("Input vacation: ");
            } while (!int.TryParse(Console.ReadLine(), out vacation));

            double salaryRate;
            do
            {
                Console.Write("Input salary rate: ");
            } while (!double.TryParse(Console.ReadLine(), out salaryRate));

            Id = id;
            Name = name;
            Age = age;
            DateOfJoin = dateOfJoin;
            Vacation = vacation;
            SalaryRate = salaryRate;
        }



    }
}
