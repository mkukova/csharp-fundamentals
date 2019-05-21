using System;

namespace _06.StrongNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int sum = 0;
			int digit = 0;
			int number1 = number;
			while (number>0)
			{
				digit = number % 10;
				int multiplication = 1;
				for (int i=1; i<=digit; i++)
				{
					multiplication = i * multiplication;
				}

				sum += multiplication;
				number = number / 10;
			}

			 if(sum==number1)
			{
				Console.WriteLine("yes");
			}
			 else
			{
				Console.WriteLine("no");
			}
		}
	}
}
