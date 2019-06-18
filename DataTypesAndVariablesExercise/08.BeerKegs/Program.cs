using System;

namespace _08.BeerKegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberKegs = int.Parse(Console.ReadLine());
			double max = double.MinValue;
			string biggestModel = string.Empty;
			for (int i = 0; i < numberKegs; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());
				double volume = Math.PI * radius * radius * height;
				if (volume > max)
				{
					max = volume;
					biggestModel = model;
				}
			}

			Console.WriteLine(biggestModel);
		}
	}
}
