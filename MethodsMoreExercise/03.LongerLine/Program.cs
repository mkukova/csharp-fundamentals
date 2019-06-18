using System;

namespace _03.LongerLine
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] coordinates = new double[8];

			for (int i = 0; i < 8; i++)
			{
				coordinates[i] = double.Parse(Console.ReadLine());
			}

			double firstLine = Line(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
			double secondLine = Line(coordinates[4], coordinates[5], coordinates[6], coordinates[7]);

			if (firstLine > secondLine)
			{
				CenterPoint(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
			}
			else
			{
				CenterPoint(coordinates[4], coordinates[5], coordinates[6], coordinates[7]);
			}
		}

		static void CenterPoint(double x1, double y1, double x2, double y2)
		{
			double firstDistance = Math.Sqrt((x1 * x1) + (y1 * y1));
			double secondDistance = Math.Sqrt((x2 * x2) + (y2 * y2));

			if (firstDistance <= secondDistance)
			{
				Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
			}
			else
			{
				Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
			}
		}

		static double Line(double x1, double y1, double x2, double y2)
		{
			double lineLenght = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2);
			return lineLenght;
		}
	}

}
