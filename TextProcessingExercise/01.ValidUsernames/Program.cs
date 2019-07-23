using System;

namespace _01.ValidUsernames
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(", ");

			foreach (var username in input)
			{
				bool isValid = false;

				if (username.Length > 3 && username.Length <= 16)
				{
					isValid = IsValidUsername(username);
				}

				if (isValid)
				{
					Console.WriteLine(username);
				}
			}
		}

		static bool IsValidUsername(string username)
		{
			foreach (var symbol in username)
			{
				if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
				{
					continue;
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}
