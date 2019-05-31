using System;

namespace _05.DecryptingMessage
{
	class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			int numberLines = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberLines; i++)
			{
				char letter = char.Parse(Console.ReadLine());
				int newLetter = (int)letter + key;
				Console.Write((char)newLetter);
			}
		}
	}
}
