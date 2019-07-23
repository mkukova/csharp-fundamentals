using System;
using System.Text;

namespace _02.RepeatStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			StringBuilder result = new StringBuilder();

			foreach (var word in words)
			{
				int lenght = word.Length;

				for (int i = 0; i < lenght ; i++)
				{
					result.Append(word);
				}
			}

			Console.WriteLine(result.ToString());
		}
	}
}
