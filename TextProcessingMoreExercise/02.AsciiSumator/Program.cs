using System;
using System.Linq;

namespace _02.AsciiSumator
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstCharacter = char.Parse(Console.ReadLine());
			char secondCharacter = char.Parse(Console.ReadLine());
			string text = Console.ReadLine();
			int sum = 0;
			int firstCharAsciiCode = (int)firstCharacter;
			int secondCharAsciiCode = (int)secondCharacter;
			int biggerNumber = 0;
			int smallerNumber = 0;

			if (firstCharAsciiCode > secondCharAsciiCode)
			{
				biggerNumber = firstCharAsciiCode;
				smallerNumber = secondCharAsciiCode;
			}
			else
			{
				biggerNumber = secondCharAsciiCode;
				smallerNumber = firstCharAsciiCode;
			}

			for (int i = 0; i < text.Length; i++)
			{
				int currentAsciiCode = (int)text[i];

				if (currentAsciiCode > smallerNumber && currentAsciiCode < biggerNumber)
				{
					sum += currentAsciiCode;
				}
			}

			Console.WriteLine(sum);
		}
	}
}
