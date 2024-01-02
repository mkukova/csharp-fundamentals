using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02.OldestFamilyMember
{
	class Family
	{
		public List<Person> People { get; set; }

		public Family()
		{
			this.People = new List<Person>();
		}
		public void AddMembers(Person member)
		{
			People.Add(member);
		}
		public Person GetOldestMember()
		{
			List<Person> sortedMembers = People.OrderByDescending(x => x.Age).ToList();
			Person oldestPerson = sortedMembers.First();
			return oldestPerson;
		}
	}
}
