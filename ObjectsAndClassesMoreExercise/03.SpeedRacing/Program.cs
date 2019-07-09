using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberCars = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();

			for (int i = 0; i < numberCars; i++)
			{
				string[] input = Console.ReadLine().Split(" ");
				Car currentCar = new Car();
				currentCar.Model = input[0];
				currentCar.FuelAmount = double.Parse(input[1]);
				currentCar.FuelConsumption = double.Parse(input[2]);
				currentCar.TraveledDistance = 0;
				cars.Add(currentCar);
			}

			string command = Console.ReadLine();

			while (command != "End")
			{
				string[] info = command.Split(" ");
				string modelToDrive = info[1];
				double distanseToDrive = double.Parse(info[2]);
				cars.Where(x => x.Model == modelToDrive)
					.ToList()
					.ForEach(x => x.CanBeDriven(distanseToDrive));
				command = Console.ReadLine();
			}

			foreach (var car in cars)
			{
				Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
			}
		}
	}
}
