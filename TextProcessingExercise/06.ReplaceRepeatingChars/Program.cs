using System;
using System.Text;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine().ToString();
			string result = string.Empty;

			if (input == string.Empty)
			{
				Console.WriteLine(" ");
				return;
			}

			int inputLenght = input.Length - 1;

			if (inputLenght == 0)
			{
				Console.WriteLine(input);
				return;
			}

			for (int i = 0; i < inputLenght; i++)
			{
				char symbol = input[i];

				if (symbol != input[i + 1])
				{
					result += symbol;
				}
			}

			if (input[inputLenght - 1] != input[inputLenght - 2])
			{
				result += input[inputLenght];
			}

			Console.WriteLine(result);
		}
	}
}

