using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfArticles = int.Parse(Console.ReadLine());
			List<Article> articles = new List<Article>();

			for (int i = 0; i < numberOfArticles; i++)
			{
				string[] input = Console.ReadLine().Split(",");
				Article currentArticle = new Article(input[0], input[1], input[2]);
				articles.Add(currentArticle);
			}

			string criteria = Console.ReadLine();

			switch (criteria)
			{
				case "title":
					articles = articles.OrderBy(x => x.Title).ToList();
					break;
				case "content":
					articles = articles.OrderBy(x => x.Content).ToList();
					break;
				case "author":
					articles = articles.OrderBy(x => x.Author).ToList();
					break;
			}

			for (int i = 0; i < numberOfArticles; i++)
			{
				articles[i].AtricleToString();
			}
		}
	}
}
