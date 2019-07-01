using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.AnonymousThreat
{
	class Program
	{
		static void Divide(List<string> input, int index, int partitions)
		{
			string partitionData = input[index];
			input.RemoveAt(index);
			int partSize = partitionData.Length / partitions;
			int reminder = partitionData.Length % partitions;

			List<string> temporaryData = new List<string>();

			for (int i = 0; i < partitions; i++)
			{
				string temporaryString = null;

				for (int j = 0; j < partSize; j++)
				{
					temporaryString += partitionData[(i * partSize) + j];
				}

				if (i == partitions - 1 && reminder != 0)
				{
					temporaryString += partitionData.Substring(partitionData.Length - reminder);
				}

				temporaryData.Add(temporaryString);
			}

			input.InsertRange(index, temporaryData);
		}

		static void Merge(List<string> input, int startIndex, int endIndex)
		{
			if (startIndex < 0)
			{
				startIndex = 0;
			}
			if (endIndex > input.Count - 1)
			{
				endIndex = input.Count - 1;
			}

			for (int j = startIndex + 1; j <= endIndex; j++)
			{
				input[startIndex] += input[startIndex + 1];
				input.RemoveAt(startIndex + 1);
			}
		}

		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine()
				.Split()
				.ToList();

			while (true)
			{
				string[] command = Console.ReadLine()
					.Split()
					.ToArray();

				if (command[0] == "3:1")
				{
					Console.Write(string.Join(" ", input));
					break;
				}
				else if (command[0] == "divide")
				{
					int index = int.Parse(command[1]);
					int partitions = int.Parse(command[2]);
					Divide(input, index, partitions);
				}
				else if (command[0] == "merge")
				{
					int startIndex = int.Parse(command[1]);
					int endIndex = int.Parse(command[2]);
					Merge(input, startIndex, endIndex);
				}
			}
		}
	}
}
