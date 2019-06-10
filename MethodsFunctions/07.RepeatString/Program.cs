using System;

namespace _07.RepeatString
{
	class Program
	{
		static void Main(string[] args)
		{
			string strings = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());
			Console.WriteLine(RepeatString(strings, count));
		}

		static string RepeatString(string a, int count)
		{
			string result = "";

			for (int i = 0; i < count; i++)
			{
				result += a;
			}

			return result;
		}
	}
}
