using System;
using System.Numerics;

namespace _04.TribonacciSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger number = BigInteger.Parse(Console.ReadLine());

			if (number <= 0)
			{
				Console.WriteLine(0);
			}
			else if (number == 1)
			{
				Console.Write(1);
			}
			else if (number == 2)
			{
				Console.Write("1 1");
			}
			else if (number == 3)
			{
				Console.Write("1 1 2");
			}
			else
			{
				Console.Write("1 1 2 ");
				GetTribonacciNumber(number);
			}
		}

		static void GetTribonacciNumber(BigInteger num)
		{
			BigInteger num3 = 1;
			BigInteger num2 = 1;
			BigInteger num1 = 2;
			BigInteger max = num;
			for (int i = 0; i < max - 3; i++)
			{
				num = num3 + num2 + num1;
				num3 = num2;
				num2 = num1;
				num1 = num;
				Console.Write($"{num} ");
			}
		}
	}
}
