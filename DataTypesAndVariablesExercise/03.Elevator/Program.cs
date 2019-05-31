using System;

namespace _03.Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberPeople = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());
			int courses = (int)Math.Ceiling((double)numberPeople / capacity);
			Console.WriteLine(courses);
		}
	}
}
