using System;

namespace _10.PokeMon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePower = int.Parse(Console.ReadLine());
			int distance = int.Parse(Console.ReadLine());
			int exhaustionFactor = int.Parse(Console.ReadLine());
			int pokedTargets = 0;
			int n = pokePower;
			while (pokePower >= distance)
			{
				pokePower -= distance;
				pokedTargets++;
				if (pokePower == n / 2.0)
				{
					if (exhaustionFactor != 0)
					{
						pokePower /= exhaustionFactor;
					}
				}
			}

			Console.WriteLine(pokePower);
			Console.WriteLine(pokedTargets);
		}
	}
}
