using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
	public class Contact
	{
		public Contact(int id, string name, string number)
		{
			this.Name = name;
			this.Number = number;
			this.Id = id;
		}
		[Required]
		public string Name { get; set; }
		[Required]
		public string Number { get; set; }
		public int Id { get; set; }
	}
}
