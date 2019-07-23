using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var letters = new StringBuilder();
			var digits = new StringBuilder();
			var others = new StringBuilder();

			for (int i = 0; i < input.Length; i++)
			{
				char symbol = input[i];

				if (char.IsDigit(symbol))
				{
					letters.Append(symbol);
				}
				else if (char.IsLetter(symbol))
				{
					digits.Append(symbol);
				}
				else
				{
					others.Append(symbol);
				}
			}

			Console.WriteLine(letters.ToString());
			Console.WriteLine(digits.ToString());
			Console.WriteLine(others.ToString());
		}
	}
}
