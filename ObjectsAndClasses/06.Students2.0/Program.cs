using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Students2._0
{
	class Program
	{
		static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
		{
			foreach (Student student in students)
			{
				if (student.FirstName == firstName && student.LastName == lastName)
				{
					return true;
				}
			}

			return false;
		}

		static Student GetStudent(List<Student> students, string firstName, string lastName)
		{
			Student existingStudent = null;

			foreach (Student student in students)
			{
				if (student.FirstName == firstName && student.LastName == lastName)
				{
					existingStudent = student;
				}
			}

			return existingStudent;
		}

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

				if (IsStudentExisting(students, firstName, lastName))
				{
					Student student = GetStudent(students, firstName, lastName);
					student.FirstName = firstName;
					student.LastName = lastName;
					student.Age = age;
					student.City = city;
				}
				else
				{
					Student student = new Student()
					{
						FirstName = firstName,
						LastName = lastName,
						Age = age,
						City = city
					};

					students.Add(student);
				}

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
