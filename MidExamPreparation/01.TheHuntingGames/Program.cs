using System;

namespace _01.TheHuntingGames
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfDays = int.Parse(Console.ReadLine());
			int countOfPlayers = int.Parse(Console.ReadLine());
			double groupEnergy = double.Parse(Console.ReadLine());
			double waterPerDay = double.Parse(Console.ReadLine());
			double foodPerDay = double.Parse(Console.ReadLine());

			double neededFood = foodPerDay * numberOfDays * countOfPlayers;
			double neededWater = waterPerDay * numberOfDays * countOfPlayers;

			for (int i = 1; i <= numberOfDays; i++)
			{
				double energyLoss = double.Parse(Console.ReadLine());

				if ((groupEnergy - energyLoss) > 0)
				{
					groupEnergy -= energyLoss;
				}
				else
				{
					Console.WriteLine($"You will run out of energy. You will be left with {neededFood:F2} food and {neededWater:F2} water.");
					return;
				}

				if (i % 2 == 0)
				{
					groupEnergy += (groupEnergy * 0.05);
					neededWater -= (neededWater * 0.3);
				}

				if (i % 3 == 0)
				{
					neededFood -= (neededFood / countOfPlayers);
					groupEnergy += (groupEnergy * 0.1);
				}
			}

			Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
		}
	}
}
