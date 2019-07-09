using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehicles = new List<Vehicle>();
			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] information = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				double currentHorsepower = double.Parse(information[3]);
				Vehicle currentVehicle = new Vehicle(information[0].ToLower(), information[1], information[2].ToLower(), currentHorsepower);
				vehicles.Add(currentVehicle);
				input = Console.ReadLine();
			}

			string searchedModel = Console.ReadLine();

			while (searchedModel != "Close the Catalogue")
			{
				Console.WriteLine(vehicles.Find(x => x.Model == searchedModel));
				searchedModel = Console.ReadLine();
			}

			List<Vehicle> cars = vehicles.Where(x => x.Type == "car").ToList();
			List<Vehicle> trucks = vehicles.Where(x => x.Type == "truck").ToList();

			double totalCarsPower = 0.0;
			double totalTrucksPower = 0.0;

			foreach (var car in cars)
			{
				totalCarsPower += car.HorsePower;
			}

			foreach (var truck in trucks)
			{
				totalTrucksPower += truck.HorsePower;
			}

			double averageCarsPower = totalCarsPower / cars.Count();
			double averageTrucksPower = totalTrucksPower / trucks.Count();

			if (averageCarsPower > 0)
			{
				Console.WriteLine($"Cars have average horsepower of: {averageCarsPower:f2}.");
			}
			else
			{
				Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
			}

			if (averageTrucksPower > 0)
			{
				Console.WriteLine($"Trucks have average horsepower of: {averageTrucksPower:f2}.");
			}
			else
			{
				Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
			}
		}
	}

}
