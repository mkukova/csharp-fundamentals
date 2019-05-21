using System;

namespace _05.Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			int counter = 0;
			bool isValidLetter = false;
			int j = 0;
			while (counter < 4)
			{
				string password = Console.ReadLine();
				for (int i = username.Length - 1; i >= 0; i--)
				{
					if (username[i] == password[j])
					{
						j++;
						isValidLetter = true;
						continue;
					}
					else
					{
						isValidLetter = false;
						break;
					}
				}

				if (isValidLetter)
				{
					Console.WriteLine($"User {username} logged in.");
					return;
				}
				else
				{
					counter++;
					if (counter == 4)
					{
						Console.WriteLine($"User {username} blocked!");
					}
					else
					{
						Console.WriteLine("Incorrect password. Try again.");
					}
				}

				j = 0;
				isValidLetter = false;
			}
		}
	}
}
