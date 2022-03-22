using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Articles
{
    internal class Program
    {
        class Article
        {
            public Article(string t,string c,string a)
            {
                Title = t;
                Content = c;
                Author = a;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            

            public string Edit(string content)
            {
                Content=content;
                return Content;
            }
            public string ChangeAuthor(string author)
            {
                Author = author;
                return Author;
            }
            public string Rename(string title)
            {
                Title = title;
                return Title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine()
                .Split(", ")
                .ToList();
            Article article = new Article(inputLine[0],inputLine[1],inputLine[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ");
                
                    if (command[0]=="Edit")
                    {
                        article.Edit(command[1]);
                    }
                    else if (command[0]=="ChangeAuthor")
                    {
                        article.ChangeAuthor(command[1]);
                    }
                    else if (command[0]=="Rename")
                    {
                        article.Rename(command[1]);
                    }
                
            }

            Console.WriteLine(article.ToString());
        }
    }
}
