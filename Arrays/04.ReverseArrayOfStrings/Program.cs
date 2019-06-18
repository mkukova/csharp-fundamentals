using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] items = Console.ReadLine().Split(' ').ToArray();
			for (int i = items.Length - 1; i >= 0; i--)
			{
				Console.Write($"{items[i]} ");
			}
		}
	}
}
