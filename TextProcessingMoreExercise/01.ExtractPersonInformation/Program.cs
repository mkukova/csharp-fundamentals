using System;

namespace _01.ExtractPersonInformation
{
	class Program
	{
		static void Main(string[] args)
		{
			int linesOfInformation = int.Parse(Console.ReadLine());

			for (int i = 0; i < linesOfInformation; i++)
			{
				string input = Console.ReadLine();
				int startIndexName = input.IndexOf('@');
				int endIndexName = input.IndexOf('|');
				int startIndexAge = input.IndexOf('#');
				int endIndexAge = input.IndexOf('*');

				string name = input.Substring(startIndexName + 1, endIndexName - startIndexName - 1);
				string age = input.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);

				Console.WriteLine($"{name} is {age} years old.");
			}
		}
	}
}
