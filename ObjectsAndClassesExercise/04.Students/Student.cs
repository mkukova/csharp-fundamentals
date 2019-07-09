using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Students
{
	class Student
	{
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public double Grade { get; set; }
		public Student(string firstName, string secondName, double grade)
		{
			this.FirstName = firstName;
			this.SecondName = secondName;
			this.Grade = grade;
		}
		public void PrintInformation()
		{
			Console.WriteLine($"{this.FirstName} {this.SecondName}: {this.Grade:F2}");
		}
	}
}
