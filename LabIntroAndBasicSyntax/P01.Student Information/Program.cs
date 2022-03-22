using System;

namespace P01.Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {firstName}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
