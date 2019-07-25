using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
			var phoneMatches = Regex.Matches(input, pattern);
			var matchedPhones = phoneMatches
				.Cast<Match>()
				.Select(x => x.Value.Trim())
				.ToArray();
			Console.WriteLine(string.Join(", ", matchedPhones));
		}
	}
}
