﻿using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int count = numbers.Length;
			while (count > 0)
			{
				for (int i = 0; i < count - 1; i++)
				{
					numbers[i] = numbers[i] + numbers[i + 1];
				}

				count--;
			}

			Console.WriteLine(numbers[0]);
		}
	}
}
