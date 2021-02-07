using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskEntityFrameworkCore.Model
{
		class Team
		{
			[Key]
			public int Id { get; set; }
			public string Name { get; set; }
		}
}
