using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _01.Furniture
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>[0-9]+.[0-9]+)!(?<quantity>[0-9]+)";
			Regex regex = new Regex(pattern);
			var furniture = new Dictionary<string, double[]>();

			while (input != "Purchase")
			{
				if (regex.IsMatch(input))
				{
					
				}
			}
		}
	}
}
