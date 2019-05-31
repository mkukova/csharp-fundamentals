using System;

namespace _05.PrintPartOfASCIITable
{
	class Program
	{
		static void Main(string[] args)
		{
			int startIndex = int.Parse(Console.ReadLine());
			int finalindex = int.Parse(Console.ReadLine());
			for (int i = startIndex; i <= finalindex; i++)
			{
				Console.Write($"{(char)i} ");
			}
		}
	}
}
