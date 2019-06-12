using System;

namespace _02.VowelsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine().ToLower();
			int numberVowels = VowelsCount(text);
			Console.WriteLine(numberVowels);
		}

		static int VowelsCount(string a)
		{
			int counter = 0;
			for (int i = 0; i < a.Length; i++)
			{
				switch (a[i])
				{
					case 'o':
					case 'i':
					case 'a':
					case 'u':
					case 'e':
						counter++;
						break;
				}
			}

			return counter;
		}
	}
}
