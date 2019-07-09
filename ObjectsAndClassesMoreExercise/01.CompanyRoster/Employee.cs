using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CompanyRoster
{
	class Employee
	{
		public string Name { get; set; }
		public double Salary { get; set; }
		public Employee(string name, double salary)
		{
			this.Name = name;
			this.Salary = salary;
		}
	}
}
