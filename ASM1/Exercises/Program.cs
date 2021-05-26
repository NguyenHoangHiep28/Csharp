using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            Student student1 = new Student();
            student1.StudentID = 1;
            student1.StudentName = "David George";
            student1.Age = 18;
            student1.Gender = 'M';
            student1.percentage = 75.50;
            Console.WriteLine(student1.ToString());

            //Exercise 2

            /// <summary>
            /// <param name="args">commnet</param>
            /// </summary>
            /// <remarks>
            /// comment
            /// </remarks>

            //Exercise 3
            const int oneHundred = 100;
            string studentName;
            float maths, english, physics;
            double percent = 0;
            Console.WriteLine("Enter name of the student: ");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter marks for Maths: ");
            float.TryParse(Console.ReadLine(), out maths);
            Console.WriteLine("Enter marks for Physics: ");
            float.TryParse(Console.ReadLine(), out physics);
            Console.WriteLine("Enter marks for English: ");
            float.TryParse(Console.ReadLine(), out english);
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Marks obtained in English: {english}");
            Console.WriteLine($"Marks obtained in Maths: {maths}");
            Console.WriteLine($"Marks obtained in Physics: {physics}");
            percent = (maths + english + physics) * oneHundred / 300;
            Console.WriteLine($"Percent: {percent.ToString("F2")}");
            Console.ReadKey();
        }
    }
    class Student
    {
        private int studentID, age;
        private string studentName;
        private char gender;
        private double percent;

        public Student() { }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public double percentage
        {
            get { return percent; }
            set { percent = value; }
        }
        public override string ToString()
        {
            return "Student ID: " + this.StudentID + "\n"
                + "Student Name: " + this.StudentName + "\n"
                + "Age: " + this.Age + "\n"
                + "Gender: " + this.Gender + "\n"
                + "Percentage: " + this.percentage;
        }
    }
}
