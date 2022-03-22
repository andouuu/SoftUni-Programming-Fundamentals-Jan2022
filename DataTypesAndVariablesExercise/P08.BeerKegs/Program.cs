using System;

namespace P08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            float biggestKeg = float.MinValue;
            for (int i = 0; i < n; i++)
            {
                string model=Console.ReadLine();
                float radius=float.Parse(Console.ReadLine());
                int height=int.Parse(Console.ReadLine());
                float volume = (float) Math.PI * (radius * radius) * height;
                if (volume>biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
