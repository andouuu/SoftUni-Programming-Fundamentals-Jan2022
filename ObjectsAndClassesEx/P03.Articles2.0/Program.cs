using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles2._0
{
    internal class Program
    {
        class Article
        {
            

            public Article(string t, string c, string a)
            {
                Title = t;
                Content = c;
                Author = a;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] articleToAdd=Console.ReadLine().Split(", ");
                Article article = new Article(articleToAdd[0], articleToAdd[1], articleToAdd[2]);
                articles.Add(article);
            }

            string type = Console.ReadLine();
            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }

        }
    }
}

