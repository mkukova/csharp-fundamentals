using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.HTML
{
	class Program
	{
		static void Main(string[] args)
		{
			string title = Console.ReadLine();
			string content = Console.ReadLine();
			string comment = Console.ReadLine();
			List<string> commentsList = new List<string>();

			while (comment != "end of comments")
			{
				commentsList.Add(comment);
				comment = Console.ReadLine();
			}

			Console.WriteLine("<h1>");
			Console.WriteLine($"	{title}");
			Console.WriteLine("</h1>");
			Console.WriteLine("<article>");
			Console.WriteLine($"	{content}");
			Console.WriteLine("</article>");

			for (int i = 0; i < commentsList.Count; i++)
			{
				Console.WriteLine("<div>");
				Console.WriteLine($"	{commentsList[i]}");
				Console.WriteLine("</div>");
			}
		}
	}
}
