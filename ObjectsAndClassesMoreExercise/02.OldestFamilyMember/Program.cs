using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberPeople = int.Parse(Console.ReadLine());
			Family family = new Family();

			for (int i = 0; i < numberPeople; i++)
			{
				string[] input = Console.ReadLine().Split(" ");
				Person person = new Person();
				person.Name = input[0];
				person.Age = int.Parse(input[1]);
				family.AddMembers(person);
			}

			Person oldestPerson = family.GetOldestMember();
			Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
		}
	}
}
