using System;
using System.Collections.Generic;
using System.Text;

namespace _05.TeamworkProjects
{
	class Team
	{
		public string CreatorName { get; set; }
		public string TeamName { get; set; }
		public List<string> Members { get; set; }

		public Team(string creator, string name)
		{
			this.CreatorName = creator;
			this.TeamName = name;
		}
	}
}
