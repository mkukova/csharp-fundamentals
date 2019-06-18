using System;

namespace _01.DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine().ToLower();
			string variable = Console.ReadLine();
			DataTypes(type, variable);
		}

		static void DataTypes(string type, string variable)
		{
			switch (type)
			{
				case "int":
					int number = int.Parse(variable);
					Console.WriteLine(number * 2);
					break;
				case "real":
					double result = double.Parse(variable);
					result *= 1.5;
					Console.WriteLine($"{result:F2}");
					break;
				case "string":
					Console.WriteLine($"${variable}$");
					break;
			}
		}
	}
}
