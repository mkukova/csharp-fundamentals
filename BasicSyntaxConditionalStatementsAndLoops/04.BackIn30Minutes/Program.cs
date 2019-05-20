using System;

namespace _04.BackIn30Minutes
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int newMinutes = minutes + 30;
			while (newMinutes > 60)
			{
				newMinutes -= 60;
				hours += 1;
			}

			while (hours >= 24)
			{
				hours = hours - 24;
			}

			if (newMinutes < 10)
			{
				Console.WriteLine($"{hours}:0{newMinutes}");
			}
			else
			{
				Console.WriteLine($"{hours}:{newMinutes}");
			}
		}
	}
}
