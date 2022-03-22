using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students= new List<Student>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] currStudentInput=input
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Student currStudent=new Student();
                currStudent.FirstName=currStudentInput[0];
                currStudent.LastName=currStudentInput[1];
                currStudent.Age=currStudentInput[2];
                currStudent.HomeTown=currStudentInput[3];
                students.Add(currStudent);
            }

            string town = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown==town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
