using System;

namespace _09.GreaterOfTwoValues
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine().ToLower();

			switch (type)
			{
				case "int":
					int number1 = int.Parse(Console.ReadLine());
					int number2 = int.Parse(Console.ReadLine());
					Console.WriteLine(GetMaxInt(number1, number2));
					break;
				case "char":
					char variable1 = char.Parse(Console.ReadLine());
					char variable2 = char.Parse(Console.ReadLine());
					Console.WriteLine(GetMaxChar(variable1, variable2));
					break;
				case "string":
					string var1 = Console.ReadLine();
					string var2 = Console.ReadLine();
					Console.WriteLine(GetMaxString(var1, var2));
					break;
				default:
					Console.WriteLine("Invalid variable type!");
					break;
			}
		}

		static int GetMaxInt(int value1, int value2)
		{
			if (value1 > value2)
			{
				return value1;
			}
			else
			{
				return value2;
			}
		}

		static char GetMaxChar(char ch1, char ch2)
		{
			if (ch1 > ch2)
			{
				return ch1;
			}
			else
			{
				return ch2;
			}
		}

		static string GetMaxString(string str1, string str2)
		{
			if (str1.CompareTo(str2) >= 0)
			{
				return str1;
			}
			else
			{
				return str2;
			}
		}
	}
}
