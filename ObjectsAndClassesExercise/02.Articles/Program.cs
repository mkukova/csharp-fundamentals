using System;
using System.Collections.Generic;


namespace _02.Articles
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);
			Article article = new Article(input[0], input[1], input[2]);

			int numberCommands = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberCommands; i++)
			{
				string[] command = Console.ReadLine().Split(":");

				switch (command[0])
				{
					case "Edit":
						article.Edit(command[1]);
						break;
					case "ChangeAuthor":
						article.ChangeAuthor(command[1]);
						break;
					case "Rename":
						article.Rename(command[1]);
						break;
					default:
						Console.WriteLine("Incorrect command!");
						break;
				}
			}

			article.AtricleToString();
		}
	}
}
