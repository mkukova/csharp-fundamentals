using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
	class Vehicle
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public double HorsePower { get; set; }

		public Vehicle(string type, string model, string color, double horsePower)
		{
			this.Type = type;
			this.Model = model;
			this.Color = color;
			this.HorsePower = horsePower;
		}

		public override string ToString()
		{
			string vehiclestr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +

								$"Model: {this.Model}{Environment.NewLine}" +

								$"Color: {this.Color}{Environment.NewLine}" +

								$"Horsepower: {this.HorsePower}";
			return vehiclestr;
		}
	}
}
