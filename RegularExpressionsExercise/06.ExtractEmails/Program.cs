using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _06.ExtractEmails
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex emailRegex = new Regex(@"(\s[a-z]+[\w.-]+\w)@([a-z]+[-a-z]*?([.][a-z]+)+)\b");
			string input = Console.ReadLine();
			Console.WriteLine(string.Join(Environment.NewLine, emailRegex.Matches(input)));
		}
	}
}
