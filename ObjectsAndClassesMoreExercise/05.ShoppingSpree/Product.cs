using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ShoppingSpree
{
	class Product
	{
		public string ProductName { get; set; }
		public double Cost { get; set; }
		public Product(string name, double cost)
		{
			this.ProductName = name;
			this.Cost = cost;
		}
	}
}
