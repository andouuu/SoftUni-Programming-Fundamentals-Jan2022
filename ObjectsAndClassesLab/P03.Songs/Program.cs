using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs=new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Song song = new Song();
                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];
                songs.Add(song);
            }
            string songType=Console.ReadLine();
            foreach (var type in songs)
            {
                if (type.TypeList==songType)
                {
                    Console.WriteLine(type.Name);
                } 
                else if (songType=="all")
                {
                    Console.WriteLine(type.Name);
                }
            }
        }
    }
}
