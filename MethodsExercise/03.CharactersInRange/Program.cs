using System;

namespace _03.CharactersInRange
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstSymbol = char.Parse(Console.ReadLine());
			char secondSymbol = char.Parse(Console.ReadLine());
			CharactersInRange(firstSymbol, secondSymbol);
		}

		static void CharactersInRange(char firstChar, char secondChar)
		{
			if (firstChar < secondChar)
			{
				for (int i = firstChar + 1; i < secondChar; i++)
				{
					Console.Write($"{(char)i} ");
				}
			}
			else
			{
				for (int i = secondChar + 1; i < firstChar; i++)
				{
					Console.Write($"{(char)i} ");
				}
			}

		}
	}
}
