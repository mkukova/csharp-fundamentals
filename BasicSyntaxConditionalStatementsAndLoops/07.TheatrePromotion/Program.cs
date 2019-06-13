using System;

namespace _07.TheatrePromotion
{
	class Program
	{
		static void Main(string[] args)
		{
			string day = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			int price = 0;
			bool isValid = true;
			switch (day)
			{
				case "Weekday":
					if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
					{
						price = 12;
					}
					else if (age > 18 && age <= 64)
					{
						price = 18;
					}
					else
					{
						isValid = false;
					} 

					break;
				case "Weekend":
					if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
					{
						price = 15;
					}
					else if (age > 18 && age <= 64)
					{
						price = 20;
					}
					else
					{
						isValid = false;
					}

					break;
				case "Holiday":
					if (age >= 0 && age <= 18)
					{
						price = 5;
					}
					else if (age > 18 && age <= 64)
					{
						price = 12;
					}
					else if (age > 64 && age <= 122)
					{
						price = 10;
					}
					else
					{
						isValid = false;
					}

					break;
				default:
					isValid = false;
					break;
			}

			if (isValid)
			{
				Console.WriteLine($"{price}$");
			}
			else
			{
				Console.WriteLine("Error!");
			}

		}
	}
}
