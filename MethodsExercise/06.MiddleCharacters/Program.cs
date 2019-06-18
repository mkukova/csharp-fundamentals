using System;

namespace _06.MiddleCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			MiddleCharacter(text);
		}

		static void MiddleCharacter(string a)
		{
			int stringLenght = a.Length;
			if (stringLenght % 2 == 0)
			{
				Console.WriteLine($"{a[(stringLenght / 2) - 1]}{a[stringLenght / 2]}");
			}
			else
			{
				Console.WriteLine(a[(stringLenght / 2)]);
			}
		}
	}
}
