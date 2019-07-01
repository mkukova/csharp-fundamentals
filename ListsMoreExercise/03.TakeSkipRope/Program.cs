using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _03.TakeSkipRope
{
	class Program
	{
		static void Main(string[] args)
		{
			string hiddenMessage = Console.ReadLine();
			List<int> numbers = new List<int>();
			List<int> takeList = new List<int>();
			List<int> skipList = new List<int>();
			List<string> nonNumbers = new List<string>();
			string result = string.Empty;

			for (int i = 0; i < hiddenMessage.Length; i++)
			{
				if (char.IsDigit(hiddenMessage[i]))
				{
					numbers.Add(int.Parse(hiddenMessage[i].ToString()));
				}
				else
				{
					nonNumbers.Add(hiddenMessage[i].ToString());
				}
			}

			for (int i = 0; i < numbers.Count; i++)
			{
				if (i % 2 == 0)
				{
					takeList.Add(numbers[i]);
				}
				else
				{
					skipList.Add(numbers[i]);
				}
			}

			nonNumbers.Reverse();
			int nonNumbersLenght = nonNumbers.Count - 1;
			bool isEmpty = false;

			for (int i = 0; i < takeList.Count; i++)
			{
				for (int j = 0; j < takeList[i]; j++)
				{
					result += nonNumbers[nonNumbersLenght];
					nonNumbers.RemoveAt(nonNumbersLenght);
					nonNumbersLenght--;

					if (nonNumbersLenght < 0)
					{
						isEmpty = true;
						break;
					}
				}

				for (int k = 0; k < skipList[i]; k++)
				{
					nonNumbers.RemoveAt(nonNumbersLenght);
					nonNumbersLenght--;

					if (nonNumbersLenght < 0)
					{
						isEmpty = true;
						break;
					}
				}

				if (isEmpty)
				{
					break;
				}
			}

			Console.WriteLine(result);
		}
	}
}
