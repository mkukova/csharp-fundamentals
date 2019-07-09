using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CompanyRoster
{
	class Department
	{
		public string DepartmentName { get; set; }
		public List<Employee> Employees { get; set; } = new List<Employee>();
		public double TotalSalaries { get; set; }
		public void AddNewEmployee(string empName, double empSalary)
		{
			this.TotalSalaries += empSalary;

			this.Employees.Add(new Employee(empName, empSalary));

		}
		public Department(string departmentName)
		{
			this.DepartmentName = departmentName;
		}
	}
}
