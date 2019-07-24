﻿using System;
using System.Text;
using System.Linq;

namespace _05.MultiplyBigNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string numberAsString = Console.ReadLine();
			int multiplier = int.Parse(Console.ReadLine());
			var builder = new StringBuilder();
			int onMind = 0;

			for (int i = numberAsString.Length - 1; i >= 0; i--)
			{
				int lastDigit = int.Parse(numberAsString[i].ToString());
				int result = lastDigit * multiplier + onMind;
				builder.Append(result % 10);
				onMind = result / 10;
			}

			if (onMind != 0)
			{
				builder.Append(onMind);
			}

			string resultNumber = string.Join("", builder
				.ToString()
				.Reverse())
				.TrimStart('0');

			if (resultNumber == string.Empty)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(resultNumber);
			}
		}
	}
}
