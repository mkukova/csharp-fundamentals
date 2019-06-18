using System;

namespace _04.ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{
			string String = Console.ReadLine();
			for (int i = (String.Length - 1); i >= 0; i--)
			{
				Console.Write(String[i]);
			}
		}
	}
}
