using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();

			while (true)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				if (input[0] == "End")
				{
					break;
				}

				string name = input[0];
				string ID = input[1];
				int age = int.Parse(input[2]);

				Person currentPerson = new Person(name, ID, age);
				people.Add(currentPerson);
			}

			people = people.OrderBy(x => x.Age).ToList();

			foreach (var person in people)
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}
		}
	}
}
