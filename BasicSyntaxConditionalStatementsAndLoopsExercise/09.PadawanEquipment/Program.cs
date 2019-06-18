using System;

namespace _09.PadawanEquipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double amountMoney = double.Parse(Console.ReadLine());
			int countOfStudents = int.Parse(Console.ReadLine());
			double lightsaber = double.Parse(Console.ReadLine());
			double robe = double.Parse(Console.ReadLine());
			double belt = double.Parse(Console.ReadLine());
			double extraLightsabersCount = Math.Ceiling(0.1 * countOfStudents);
			double freeBelts = countOfStudents / 6;
			double neededMoney = (countOfStudents * robe) + ((countOfStudents - freeBelts) * belt) + ((countOfStudents + extraLightsabersCount) * lightsaber);
			if (neededMoney <= amountMoney)
			{
				Console.WriteLine($"The money is enough - it would cost {(neededMoney):F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivan Cho will need {(neededMoney - amountMoney):F2}lv more.");
			}
		}
	}
}
