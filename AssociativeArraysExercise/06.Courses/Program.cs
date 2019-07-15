using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
	class Program
	{
		static void Main(string[] args)
		{
			var courses = new Dictionary<string, List<string>>();

			while (true)
			{
				string info = Console.ReadLine();

				if (info == "end")
				{
					break;
				}

				string[] infoArgs = info.Split(":");
				string courseName = infoArgs[0].Trim();
				string studentName = infoArgs[1].Trim();

				if (!courses.ContainsKey(courseName))
				{
					courses[courseName] = new List<string>();
				}

				courses[courseName].Add(studentName);
			}

			var result = courses.OrderByDescending(x => x.Value.Count);

			foreach (var item in result)
			{
				Console.WriteLine($"{item.Key}: {item.Value.Count}");

				foreach (var person in item.Value.OrderBy(x => x))
				{
					Console.WriteLine($"-- {person}");
				}
			}
		}
	}
}
