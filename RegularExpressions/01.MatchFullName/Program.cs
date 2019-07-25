using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
	class Program
	{
		static void Main(string[] args)
		{
			string names = Console.ReadLine();
			string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
			Regex regex = new Regex(pattern);
			MatchCollection validNmaes = regex.Matches(names);

			foreach (Match match in validNmaes)
			{
				Console.Write($"{match.Value} ");
			}
		}
	}
}
