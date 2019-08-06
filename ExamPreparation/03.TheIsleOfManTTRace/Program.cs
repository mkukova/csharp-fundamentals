using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _03.TheIsleOfManTTRace
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string input = Console.ReadLine();
				string lenghtPattern = @"=(\d+)!!";
				Match m = Regex.Match(input, lenghtPattern);

				if (m.Success)
				{
					int lenght = int.Parse(m.Groups[1].Value);
					string pattern = $@"([#$%*&])(?<name>\w+)\1=(\d+)!!(?<text>.{{{lenght}}})$";
					Match match = Regex.Match(input, pattern);

					if (match.Success)
					{
						string name = match.Groups["name"].Value;
						string coordinates = match.Groups["text"].Value;
						StringBuilder text = new StringBuilder();

						for (int i = 0; i < coordinates.Length; i++)
						{
							char symbol = (char)(coordinates[i] + lenght);
							text.Append(symbol);
						}

						Console.WriteLine($"Coordinates found! {name} -> {text.ToString()}");
						break;
					}
				}

				Console.WriteLine("Nothing found!");
			}
		}
	}
}
