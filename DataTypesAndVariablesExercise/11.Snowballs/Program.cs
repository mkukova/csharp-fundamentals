using System;
using System.Numerics;

namespace _11.Snowballs
{
	class Program
	{
		static void Main(string[] args)
		{
			int snowballCount = int.Parse(Console.ReadLine());
			BigInteger maxValue = 0; 
			int bestSnow = 0;
			int bestTime = 0;
			int bestQuality = 0;
			while (snowballCount > 0)
			{
				int snowballSnow = int.Parse(Console.ReadLine());
				int snowballTime = int.Parse(Console.ReadLine());
				int snowballQuality = int.Parse(Console.ReadLine()); 
				BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
				if (snowballValue > maxValue)
				{
					maxValue = snowballValue;
					bestSnow = snowballSnow;
					bestTime = snowballTime;
					bestQuality = snowballQuality;
				}

				snowballCount--;
			}

			Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuality})");
		}
	}
}
