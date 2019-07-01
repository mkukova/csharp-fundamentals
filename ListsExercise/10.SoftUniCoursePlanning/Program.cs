using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniCoursePlanning
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> schedule = Console.ReadLine()
				.Split(", ")
				.ToList();

			string input = Console.ReadLine();

			while (input != "course start")
			{
				string[] splitedInput = input.Split(":").ToArray();
				string command = splitedInput[0];
				string lesson = splitedInput[1];

				switch (command)
				{
					case "Add":
						if (!schedule.Contains(lesson))
						{
							schedule.Add(lesson);
						}

						break;
					case "Insert":
						int index = int.Parse(splitedInput[2]);

						if (!schedule.Contains(lesson))
						{
							schedule.Insert(index, lesson);
						}

						break;
					case "Remove":

						if (schedule.Contains(lesson))
						{
							schedule.Remove(lesson);
						}

						break;
					case "Swap":
						string secondLesson = splitedInput[2];
						string exerciseFormat = "{0}-Exercise";

						if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
						{
							int firstLessonIndex = schedule.IndexOf(lesson);
							int secondLessonIndex = schedule.IndexOf(secondLesson);

							schedule[firstLessonIndex] = secondLesson;
							schedule[secondLessonIndex] = lesson;

							string firstLessonExercise = string.Format(exerciseFormat, lesson);
							string secondLessonExercise = string.Format(exerciseFormat, secondLesson);

							if (schedule.Contains(firstLessonExercise))
							{
								int firstExerciseIndex = schedule.IndexOf(firstLessonExercise);
								schedule.Insert(secondLessonIndex + 1, firstLessonExercise);
								schedule.RemoveAt(firstExerciseIndex + 1);
							}

							if (schedule.Contains(secondLessonExercise))
							{
								int secondExerciseIndex = schedule.IndexOf(secondLessonExercise);
								schedule.Insert(firstLessonIndex + 1, secondLessonExercise);
								schedule.RemoveAt(secondExerciseIndex + 1);
							}
						}
						break;
					case "Exercise":
						string exercise = $"{lesson}-Exercise";

						if (!schedule.Contains(exercise))
						{
							if (schedule.Contains(lesson))
							{
								int indexLesson = schedule.IndexOf(lesson);
								schedule.Insert(indexLesson + 1, exercise);
							}
							else
							{
								schedule.Add(lesson);
								schedule.Add(exercise);
							}
						}
						break;
					default:
						Console.WriteLine("Invalid command!");
						break;
				}

				input = Console.ReadLine();
			}

			for (int i = 0; i < schedule.Count; i++)
			{
				Console.WriteLine($"{i + 1}.{schedule[i]}");
			}
		}
	}
}
