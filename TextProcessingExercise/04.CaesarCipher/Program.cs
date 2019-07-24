using System;
using System.Text;
using System.Linq;

namespace _04.CaesarCipher
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var result = new StringBuilder();

			for (int i = 0; i < input.Length; i++)
			{
				var symbol = (int)input[i] + 3;
				result.Append((char)symbol);
			}

			Console.WriteLine(result.ToString());
		}
	}
}
