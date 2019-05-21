using System;

namespace _03.Vacation
{
	class Program
	{
		static void Main(string[] args)
		{
			int peopleNumber = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string day = Console.ReadLine();
			double price = 0;
			double discount = 0;
			bool isValid = true;
			switch (groupType)
			{
				case "Students":
					switch (day)
					{
						case "Friday":
							price = 8.45 * peopleNumber;
							break;
						case "Saturday":
							price = 9.8 * peopleNumber;
							break;
						case "Sunday":
							price = 10.46 * peopleNumber;
							break;
						default:
							Console.WriteLine("Invalid input!");
							isValid = false;
							break;
					}

					if (peopleNumber >= 30)
					{
						discount = 0.15 * price;
						price -= discount;
					}

					break;
				case "Business":
					switch (day)
					{
						case "Friday":
							price = 10.90 * peopleNumber;
							break;
						case "Saturday":
							price = 15.6 * peopleNumber;
							break;
						case "Sunday":
							price = 16.0 * peopleNumber;
							break;
						default:
							Console.WriteLine("Invalid input!");
							isValid = false;
							break;
					}

					if (peopleNumber >= 100)
					{
						discount = (price / peopleNumber) * 10;
						price -= discount;
					}

					break;
				case "Regular":
					switch (day)
					{
						case "Friday":
							price = 15.0 * peopleNumber;
							break;
						case "Saturday":
							price = 20.0 * peopleNumber;
							break;
						case "Sunday":
							price = 22.5 * peopleNumber;
							break;
						default:
							Console.WriteLine("Invalid input!");
							isValid = false;
							break;
					}

					if (peopleNumber >= 10 && peopleNumber <= 20)
					{
						discount = 0.05 * price;
						price -= discount;
					}

					break;
				default:
					Console.WriteLine("Invalid input!");
					isValid = false;
					break;
			}

			if (isValid)
			{
				Console.WriteLine($"Total price: {price:F2}");
			}

		}
	}
}
