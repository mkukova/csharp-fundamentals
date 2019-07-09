using System;
using System.Collections.Generic;
using System.Text;

namespace _07.OrderByAge
{
	class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public int Age { get; set; }
		public Person(string name, string id, int age)
		{
			this.Name = name;
			this.ID = id;
			this.Age = age;
		}
	}
}
