using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "end")
			{
				var reversed = "";
				for (int i = input.Length-1; i >=0; i--)
				{
					reversed += input[i];
				}

				Console.WriteLine($"{input} = {reversed}");
				input = Console.ReadLine();
			}
		}
	}
}
