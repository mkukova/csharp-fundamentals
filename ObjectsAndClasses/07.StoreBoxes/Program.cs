using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StoreBoxes
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Box> boxes = new List<Box>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] info = input.Split();
				string serialNumber = info[0];
				string itemName = info[1];
				int itemQuantity = int.Parse(info[2]);
				double itemPrice = double.Parse(info[3]);
				double priceOfBox = itemPrice * itemQuantity;

				Box box = new Box();
				box.SerialNumber = serialNumber;
				box.ItemName = itemName;
				box.Quantity = itemQuantity;
				box.Item.ItemPrice = itemPrice;
				box.PriceForBox = priceOfBox;

				boxes.Add(box);
				input = Console.ReadLine();
			}

			List<Box> sortedBox = boxes.OrderBy(box => box.PriceForBox)
				.ToList();

			sortedBox.Reverse();

			foreach (Box box in sortedBox)
			{
				Console.WriteLine($"{box.SerialNumber}");
				Console.WriteLine($"-- {box.ItemName} - ${box.Item.ItemPrice:F2}: {box.Quantity}");
				Console.WriteLine($"-- ${box.PriceForBox:F2}");

			}
		}
	}
}
