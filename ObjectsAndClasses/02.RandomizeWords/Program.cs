using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.RandomizeWords
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<string> words = input.Split().ToList();
			Random rnd = new Random();

			for (int i = 0; i < words.Count-1; i++)
			{
				int index = rnd.Next(0, words.Count);
				string temp = words[i];
				words[i] = words[index];
				words[index] = temp;
			}

			foreach(var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}
