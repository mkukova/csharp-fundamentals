using System;

namespace _05.AddAndSubtract
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int result = Subtract(a, b, c);
			Console.WriteLine(result);
		}

		static int Sum(int a, int b)
		{
			return a + b;
		}

		static int Subtract(int a, int b, int c)
		{
			int result = Sum(a, b) - c;
			return result;
		}
	}
}

