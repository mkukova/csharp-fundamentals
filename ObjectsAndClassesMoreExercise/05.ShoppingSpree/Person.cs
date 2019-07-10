using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ShoppingSpree
{
	class Person
	{
		public string PersonName { get; set; }
		public double Money { get; set; }
		public List<string> BagOfProducts { get; set; } 

		public Person(string name, double money)
		{
			this.PersonName = name;
			this.Money = money;
			this.BagOfProducts = new List<string>();
		}
		public void BuyProduct(Product product)
		{
			if (product.Cost > this.Money)
			{
				Console.WriteLine($"{this.PersonName} can't afford {product.ProductName}");
			}
			else
			{
				Console.WriteLine($"{this.PersonName} bought {product.ProductName}");
				this.Money -= product.Cost;
				this.BagOfProducts.Add(product.ProductName);
			}
		}
		public override string ToString()
		{
			string person = $"{this.PersonName} - ";

			if (this.BagOfProducts.Count == 0)
			{
				person += "Nothing bought";
			}
			else
			{
				person += string.Join(", ", this.BagOfProducts);
			}

			return person;
		}
	}
}
