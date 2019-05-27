using System;

namespace _10.RageExpenses
{
	class Program
	{
		static void Main(string[] args)
		{
			int lostGames = int.Parse(Console.ReadLine());
			double headsetPrice = double.Parse(Console.ReadLine());
			double mousePrice = double.Parse(Console.ReadLine());
			double keyboardPrice = double.Parse(Console.ReadLine());
			double displayPrice = double.Parse(Console.ReadLine());
			int trashedHeadset = lostGames / 2;
			int trashedMouse = lostGames / 3;
			int trashedKeyboard = lostGames / 6;
			int trashedDisplay = trashedKeyboard / 2;
			double expenses = headsetPrice * trashedHeadset;
			expenses += mousePrice * trashedMouse;
			expenses += keyboardPrice * trashedKeyboard;
			expenses += displayPrice * trashedDisplay;
			Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
		}
	}
}
