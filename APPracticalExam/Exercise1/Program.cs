using System;

namespace APPracticalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People() { Name = "Harry", Gender = true, Age = 19 };
            Console.WriteLine("Person details: " + people.ToString());
            people.Age += 10;
            Console.WriteLine("Person details (after incrementing age): " + people.ToString());
            Console.WriteLine("---------------------------------------------------");
            People another = new People() { Name = "Jose", Gender = false, Age = 20 };
            Console.WriteLine("Person details: " + another.ToString());
            another.Age += 5;
            Console.WriteLine("Person details (after incrementing age): " + another.ToString());

            Console.ReadKey();
        }
    }
}
