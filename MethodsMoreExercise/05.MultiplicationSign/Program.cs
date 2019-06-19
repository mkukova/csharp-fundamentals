using System;

namespace _05.MultiplicationSign
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[3];

			for (int i = 0; i < 3; i++)
			{
				nums[i] = int.Parse(Console.ReadLine());
			}

			MultiplicationSign(nums);
		}

		static void MultiplicationSign(int[] nums)
		{
			int isNegative = 0;

			for (int i = 0; i < 3; i++)
			{
				if (nums[i] < 0)
				{
					isNegative++;
				}
			}

			if (nums[0] == 0 || nums[1] == 0 || nums[2] == 0)
			{
				Console.WriteLine("zero");
			}
			else if (nums[0] > 0 && nums[1] > 0 && nums[2] > 0)
			{
				Console.WriteLine("positive");
			}
			else if (isNegative == 2)
			{
				Console.WriteLine("positive");
			}
			else
			{
				Console.WriteLine("negative");
			}

		}
	}
}
