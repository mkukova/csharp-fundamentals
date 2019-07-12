using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeizeTheFire
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] fires = Console.ReadLine()
				.Split("#");

			int water = int.Parse(Console.ReadLine());
			double efforts = 0;
			List<int> fireCells = new List<int>();

			for (int i = 0; i < fires.Length; i++)
			{
				string[] fireArgs = fires[i]
					.Split(" = ");
				string type = fireArgs[0];
				int fireValue = int.Parse(fireArgs[1]);
				bool isCellValid = IsCellValid(type, fireValue);

				if (isCellValid && water - fireValue >= 0)
				{
					efforts += fireValue * 0.25;
					water -= fireValue;
					fireCells.Add(fireValue);
				}
			}

			int totalFire = fireCells.Sum();

			Console.WriteLine($"Cells:");
			foreach (var cell in fireCells)
			{
				Console.WriteLine($" - {cell}");
			}

			Console.WriteLine($"Effort: {efforts:F2}");
			Console.WriteLine($"Total Fire: {totalFire}");
		}

		static bool IsCellValid(string type, int fireValue)
		{
			if (type == "High" && (fireValue >= 81 && fireValue <= 125))
			{
				return true;
			}
			if (type == "Medium" && (fireValue >= 51 && fireValue <= 80))
			{
				return true;
			}
			if (type == "Low" && (fireValue >= 1 && fireValue <= 50))
			{
				return true;
			}

			return false;
		}
	}
}
