using System;
using System.Linq;

namespace _04.TextFilter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] banWords = Console.ReadLine().Split(", ");
			string text = Console.ReadLine();

			foreach (var banWord in banWords)
			{
				text = text.Replace(banWord, new string('*', banWord.Length));
			}

			Console.WriteLine(text);
		}
	}
}
