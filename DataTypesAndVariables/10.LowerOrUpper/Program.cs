using System;

namespace _10.LowerOrUpper
{
	class Program
	{
		static void Main(string[] args)
		{
			char character = char.Parse(Console.ReadLine());
			bool isUpper = char.IsUpper(character);
			if (isUpper)
			{
				Console.WriteLine("upper-case");
			}
			else
			{
				Console.WriteLine("lower-case");
			}
		}
	}
}
