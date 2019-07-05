using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Students
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] information = input.Split();
				string firstName = information[0];
				string lastName = information[1];
				int age = int.Parse(information[2]);
				string city = information[3];

				Student student = new Student()
				{
					FirstName = firstName,
					LastName = lastName,
					Age = age,
					City = city
				};

				students.Add(student);
				input = Console.ReadLine();
			}

			string cityFilter = Console.ReadLine();

			foreach (Student student in students)
			{
				if (student.City == cityFilter)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}
		}
	}
}
