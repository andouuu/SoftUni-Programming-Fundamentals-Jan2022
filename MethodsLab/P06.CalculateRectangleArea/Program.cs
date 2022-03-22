using System;

namespace P06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double area=CalcAreaRectangle(a, b);
            Console.WriteLine(area);
        }

        static double CalcAreaRectangle(double a, double b)
        {
            return a * b;
        }
    }
}
