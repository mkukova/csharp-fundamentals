using System;

namespace _03.GamingStore
{
	class Program
	{
		static void Main(string[] args)
		{
			double currentBalance = double.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			double balance = currentBalance;
			double price = 0;
			bool doesExist = true;
			while (command != "Game Time")
			{
				switch (command)
				{
					case "OutFall 4":
						price = 39.99;
						currentBalance -= price;
						break;
					case "CS: OG":
						price = 15.99;
						currentBalance -= price;
						break;
					case "Zplinter Zell":
						price = 19.99;
						currentBalance -= price;
						break;
					case "Honored 2":
						price = 59.99;
						currentBalance -= price;
						break;
					case "RoverWatch":
						price = 29.99;
						currentBalance -= price;
						break;
					case "RoverWatch Origins Edition":
						price = 39.99;
						currentBalance -= price;
						break;
					default:
						Console.WriteLine("Not Found");
						doesExist = false;
						break;
				}

				if (currentBalance >= 0 && doesExist)
				{
					Console.WriteLine($"Bought {command}");
				}

				if (currentBalance == 0)
				{
					Console.WriteLine("Out of money!");
					return;
				}
				else if (currentBalance < 0)
				{
					Console.WriteLine("Too Expensive");
					currentBalance += price;
				}

				command = Console.ReadLine();
				doesExist = true;
			}

			Console.WriteLine($"Total spent: ${(balance - currentBalance):F2}. Remaining: ${currentBalance:F2}");
		}
	}
}
