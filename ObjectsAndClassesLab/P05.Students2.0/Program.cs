using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace P05.Students2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] currStudentInput = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (IsStudentExisting(students, currStudentInput[0], currStudentInput[1]))
                {
                    Student student = GetExistingStudent(students,currStudentInput[0],currStudentInput[1]);
                    student.FirstName = currStudentInput[0];
                    student.LastName = currStudentInput[1];
                    student.Age = currStudentInput[2];
                    student.HomeTown = currStudentInput[3];

                }
                else
                {
                    Student currStudent = new Student()
                    {
                FirstName = currStudentInput[0],
                LastName = currStudentInput[1],
                Age = currStudentInput[2],
                HomeTown = currStudentInput[3]
                    };
                    students.Add(currStudent);
                }
                
            }

            string town = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName==firstName&&student.LastName==lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent=null;
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {

                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
