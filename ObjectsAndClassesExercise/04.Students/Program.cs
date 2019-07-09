using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfStudents = int.Parse(Console.ReadLine());
			List<Student> students = new List<Student>();
 
			for (int i = 0; i < countOfStudents; i++)
			{
				string[] input = Console.ReadLine().Split(" ");
				double currentGrade = double.Parse(input[2]);
				Student currentStudent = new Student(input[0], input[1], currentGrade);
				students.Add(currentStudent);
			}

			students = students.OrderBy(x => x.Grade).ToList();

			students.Reverse();

			for (int i = 0; i < countOfStudents; i++)
			{
				students[i].PrintInformation();
			}
		}
	}
}
