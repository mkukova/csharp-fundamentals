using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCars = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();

			for (int i = 0; i < numberOfCars; i++)
			{
				string[] input = Console.ReadLine().Split(" ");
				string model = input[0];
				int engineSpeed = int.Parse(input[1]);
				int enginePower = int.Parse(input[2]);
				int cargoWeight = int.Parse(input[3]);
				string cargoType = input[4];
				Car currentCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
				cars.Add(currentCar);
			}

			string command = Console.ReadLine();

			if (command == "fragile")
			{
				List<Car> fragileCars = cars
					.Where(x => x.Cargo.Weight < 1000 && x.Cargo.Type == "fragile")
					.ToList();
				foreach (var car in fragileCars)
				{
					Console.WriteLine(car.Model);
				}
			}
			else if (command == "flamable")
			{
				List<Car> flamableCars = cars
					.Where(x => x.Engine.Power > 250 && x.Cargo.Type == "flamable")
					.ToList();
				foreach (var car in flamableCars)
				{
					Console.WriteLine(car.Model);
				}
			}
		}
	}
}