using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    internal class Program
    {
        class Student
        {
            public Student(string fN, string sN, decimal grade)
            {
                FirstName = fN;
                SecondName = sN;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public decimal Grade { get; set; }
            public override string ToString()
            {
                return $"{FirstName} {SecondName}: {Grade}";
            }
        }
        static void Main(string[] args)
        {
            List<Student> students=new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] studentToAdd=Console.ReadLine().Split(' ');
                Student student = new Student(studentToAdd[0], studentToAdd[1], decimal.Parse(studentToAdd[2]));
                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(student => student.Grade).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
