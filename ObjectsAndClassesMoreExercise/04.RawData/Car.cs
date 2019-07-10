using System;
using System.Collections.Generic;
using System.Text;

namespace _04.RawData
{
	class Car
	{
		public string Model { get; set; }
		public Engine Engine { get; set; } = new Engine();
		public Cargo Cargo { get; set; } = new Cargo();

		public Car(string model, int speed, int power, int weight, string type)
		{
			this.Model = model;
			this.Engine.Speed = speed;
			this.Engine.Power = power;
			this.Cargo.Weight = weight;
			this.Cargo.Type = type;
		}
	}
}
