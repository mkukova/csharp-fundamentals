using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
	class Program
	{
		static void Main(string[] args)
		{
			var companiesList = new Dictionary<string, List<string>>();

			while (true)
			{
				string[] input = Console.ReadLine().Split(" -> ");

				if (input[0] == "End")
				{
					break;
				}

				string companyName = input[0];
				string employeeID = input[1];

				if (!companiesList.ContainsKey(companyName))
				{
					companiesList[companyName] = new List<string>();
				}

				if (!companiesList[companyName].Contains(employeeID))
				{
					companiesList[companyName].Add(employeeID);
				}
			}

			var orderedCompanyList = companiesList.OrderBy(x => x.Key);

			foreach (var company in orderedCompanyList)
			{
				Console.WriteLine($"{company.Key}");

				foreach (var employy in company.Value)
				{
					Console.WriteLine($"-- {employy}");
				}
			}
		}
	}
}
