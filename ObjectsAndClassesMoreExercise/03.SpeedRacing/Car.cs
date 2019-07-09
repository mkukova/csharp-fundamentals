using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SpeedRacing
{
	class Car
	{
		public string Model { get; set; }
		public double FuelAmount { get; set; }
		public double FuelConsumption { get; set; }
		public double TraveledDistance { get; set; }
		public void CanBeDriven(double km)
		{
			double neededFuel = this.FuelConsumption * km;

			if (neededFuel <= this.FuelAmount)
			{
				this.FuelAmount -= neededFuel;
				this.TraveledDistance += km;
				
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}

	}
}
