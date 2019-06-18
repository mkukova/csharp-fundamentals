using System;

namespace _09.PalindromeIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			while (number != "END")
			{
				IsPolindrome(number);
				number = Console.ReadLine();
			}
		}

		static void IsPolindrome(string a)
		{
			int stringLenght = a.Length;
			string reversedNumber = string.Empty;
			for (int i = stringLenght - 1; i >= 0; i--)
			{
				reversedNumber += a[i];
			}

			if (reversedNumber == a)
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}

		}
	}
}
