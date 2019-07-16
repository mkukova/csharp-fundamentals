using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
	class Program
	{
		static void Main(string[] args)
		{
			int studentsNumber = int.Parse(Console.ReadLine());
			var studentsList = new Dictionary<string, List<double>>();

			for (int i = 0; i < studentsNumber; i++)
			{
				string name = Console.ReadLine();
				double grade = double.Parse(Console.ReadLine());

				if (!studentsList.ContainsKey(name))
				{
					studentsList[name] = new List<double>();
				}

				studentsList[name].Add(grade);
			}

			var filteredStudents = studentsList.Where(x => x.Value.Average() >= 4.50);

			filteredStudents = filteredStudents.OrderByDescending(x => x.Value.Average());

			Console.WriteLine(string.Join(Environment.NewLine, filteredStudents.Select(x => $"{x.Key} -> {(x.Value.Average()):F2}")));
		}
	}
}
