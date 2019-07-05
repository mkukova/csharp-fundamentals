using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.VehicleCatalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			Catalog vehicles = new Catalog();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] info = input.Split("/");
				string type = info[0];
				string brand = info[1];
				string model = info[2];
				double powerOrWeight = double.Parse(info[3]);

				Car car = new Car();
				Truck truck = new Truck();

				switch (type)
				{
					case "Car":
						car.Brand = brand;
						car.Model = model;
						car.HorsePower = powerOrWeight;
						vehicles.Cars.Add(car);
						break;
					case "Truck":
						truck.Brand = brand;
						truck.Model = model;
						truck.Weight = powerOrWeight;
						vehicles.Trucks.Add(truck);
						break;
				}

				input = Console.ReadLine();
			}

			vehicles.Cars = vehicles.Cars.OrderBy(car => car.Brand).ToList();
			vehicles.Trucks = vehicles.Trucks.OrderBy(truck => truck.Brand).ToList();

			if (vehicles.Cars.Any())
			{
				Console.WriteLine("Cars:");
				foreach (Car car in vehicles.Cars)
				{
					Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
				}
			}

			if (vehicles.Trucks.Any())
			{
				Console.WriteLine("Trucks:");
				foreach (Truck truck in vehicles.Trucks)
				{
					Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
				}
			}

		}
	}
}
