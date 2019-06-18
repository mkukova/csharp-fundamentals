using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberSequences = int.Parse(Console.ReadLine());
			string[] sequences = new string[numberSequences];
			int[] stringSum = new int[numberSequences];

			for (int i = 0; i < sequences.Length; i++)
			{
				sequences[i] = Console.ReadLine();
				int sumVowels = 0;
				int sumCons = 0;
				string strings = sequences[i];

				foreach (char index in sequences[i])
				{
					if (index == 'a' || index == 'e' || index == 'i' || index == 'o' || index == 'u' ||
						index == 'A' || index == 'E' || index == 'I' || index == 'O' || index == 'U')
					{
						sumVowels += (int)index * sequences[i].Length;
					}
					else
					{
						sumCons += (int)index / sequences[i].Length;
					}
				}

				int sum = sumVowels + sumCons;
				stringSum[i] = sum;
			}

			Array.Sort(stringSum);

			foreach (int value in stringSum)
			{
				Console.WriteLine(value);
			}
		}
	}
}
