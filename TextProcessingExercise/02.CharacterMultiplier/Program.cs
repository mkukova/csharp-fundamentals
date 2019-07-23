using System;

namespace _02.CharacterMultiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");
			string firstString = input[0];
			string secondString = input[1];
			int sum = 0;

			for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
			{
				sum += (int)firstString[i] * (int)secondString[i];
			}

			if (firstString.Length > secondString.Length)
			{
				for (int i = secondString.Length; i < firstString.Length; i++)
				{
					sum += (int)firstString[i];
				}
			}
			else if (firstString.Length < secondString.Length)
			{

				for (int i = firstString.Length; i < secondString.Length; i++)
				{
					sum += (int)secondString[i];
				}
			}

			Console.WriteLine(sum);
		}
	}
}
