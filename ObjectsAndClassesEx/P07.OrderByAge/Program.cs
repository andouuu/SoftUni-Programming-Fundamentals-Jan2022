using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.OrderByAge
{
    class Student
    {
        public Student(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {

            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Student> students= new List<Student>();
           string command;
           while ((command=Console.ReadLine())!="End")
           {
               string[] info = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
               string name=info[0];
               string id=info[1];
               int age = int.Parse(info[2]);
               int counter = 0;
               Student currStudent=currStudent = new Student(name, id, age);;
               Student sameIdStudent = students.FirstOrDefault(x => x.Id == id);
               if (sameIdStudent==null)
               {
                   
                   students.Add(currStudent);
               }
               else
               {
                   
                   students.Remove(sameIdStudent);
                   students.Add(currStudent);
               }
               
           }

           List<Student> sortedStudents = students.OrderBy(x => x.Age).ToList();
           foreach (var student in sortedStudents)
           {
               Console.WriteLine(student);
           }
        }
    }
}
