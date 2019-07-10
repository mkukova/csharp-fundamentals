using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] allPeople = Console.ReadLine()
				.Split(";", StringSplitOptions.RemoveEmptyEntries);
			string[] allProducts = Console.ReadLine()
				.Split(";", StringSplitOptions.RemoveEmptyEntries);

			List<Person> people = new List<Person>();

			for (int i = 0; i < allPeople.Length; i++)
			{
				string[] currentPerson = allPeople[i]
					.Split("=", StringSplitOptions.RemoveEmptyEntries);
				Person person = new Person(currentPerson[0], double.Parse(currentPerson[1]));
				people.Add(person);
			}

			List<Product> products = new List<Product>();

			for (int i = 0; i < allProducts.Length; i++)
			{
				string[] currentProduct = allProducts[i]
					.Split("=", StringSplitOptions.RemoveEmptyEntries);
				Product product = new Product(currentProduct[0], double.Parse(currentProduct[1]));
				products.Add(product);
			}

			string command = Console.ReadLine();

			while (command != "END")
			{
				string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string personName = input[0];
				string productName = input[1];
				Person buyer = people.FirstOrDefault(x => x.PersonName == personName);
				Product product = products.FirstOrDefault(y => y.ProductName == productName);
				buyer.BuyProduct(product);
				command = Console.ReadLine();
			}

			foreach (var person in people)
			{
				Console.WriteLine(person);
			}
		}
	}
}
