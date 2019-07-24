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
			var result = new StringBuilder();

			if (input == string.Empty)
			{
				Console.WriteLine(" ");
				return;
			}

			int inputLenght = input.Length-1;

			if (inputLenght==0)
			{
				Console.WriteLine(input);
				return;
			}

			for (int i = 0; i < inputLenght - 1; i++)
			{
				char symbol = input[i];

				if (symbol != input[i + 1])
				{
					result.Append(symbol);

					if ((i + 1) == (inputLenght - 1))
					{
						result.Append(input[i + 1]);
					}
				}
			}

			if (input[inputLenght] != input[inputLenght - 1])
			{
				result.Append(input[inputLenght]);
			}

			Console.WriteLine(result.ToString());
		}
	}
}

