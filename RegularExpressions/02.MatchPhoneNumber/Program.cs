using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string phoneNumbers = Console.ReadLine();
			string pattern = @"\+\d{3}( |-)[0-9]\1\d{3}\1\d{4}\b";
			MatchCollection phoneMatches = Regex.Matches(phoneNumbers, pattern);
			var matchedPhones = phoneMatches
				.Cast<Match>()
				.Select(x => x.Value.Trim())
				.ToArray();

			Console.WriteLine(string.Join(", ", matchedPhones));
		}
	}
}
