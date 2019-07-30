using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _4.Santa_sSecretHelper
{
	class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]+?!(?<behaviour>[N|G])!";
			string input = Console.ReadLine();
			List<string> goodChildren = new List<string>();

			while (input != "end")
			{
				var newMessage = new StringBuilder();

				foreach (var letter in input)
				{
					newMessage.Append((char)(letter - key));
				}

				string newMessageAsStr = newMessage.ToString();

				Match match = Regex.Match(newMessageAsStr, pattern);

				if (match.Success)
				{
					if (match.Groups["behaviour"].Value == "G")
					{
						string name = match.Groups["name"].Value;
						goodChildren.Add(name);
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(Environment.NewLine, goodChildren));
		}
	}
}