using System;

namespace _07.VendingMachine
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			double deposit = 0;
			double bill = 0;
			double price = 0;
			while(command!="Start")
			{
				double coin = double.Parse(command);
				switch(coin)
				{
					case 0.1:
						deposit += coin;
						break;
					case 0.2:
						deposit += coin;
						break;
					case 0.5:
						deposit += coin;
						break;
					case 1:
						deposit += coin;
						break;
					case 2:
						deposit += coin;
						break;
					default:
						Console.WriteLine($"Cannot accept {coin}");
						break;
				}

				command = Console.ReadLine();
			}

			command = Console.ReadLine().ToLower();
			while(command!="end")
			{
				switch(command)
				{
					case "nuts":
						bill += 2.0;
						break;
					case "water":
						bill += 0.7;
						break;
					case "crisps":
						bill += 1.5;
						break;
					case "soda":
						bill += 0.8;
						break;
					case "coke":
						bill += 1.0;
						break;
					default:
						Console.WriteLine("Invalid product");
						break;
				}

				if(deposit<bill)
				{
					Console.WriteLine("Sorry, not enough money");				
				}
				else
				{
					Console.WriteLine($"Purchased {command}");				
				}

				command = Console.ReadLine().ToLower();
			}

			Console.WriteLine($"Change: {Math.Abs(deposit-bill):F2}");
		}
	}
}
