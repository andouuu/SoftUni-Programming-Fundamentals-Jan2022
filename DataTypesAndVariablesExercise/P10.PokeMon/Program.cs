using System;
using System.Runtime.Serialization.Formatters;

namespace P10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int counter=0;
            for (int i= N; i >= M; i-=M)
            {
                
                if (i==N*5/10)
                {
                    i /= Y;
                    if (i<M)
                    {
                        N=i;
                        break;
                    }
                }
                
                if (i-M < M)
                {
                    i-=M;
                    counter++;
                    N = i;
                    break;
                }
                counter++;

            }

            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}
