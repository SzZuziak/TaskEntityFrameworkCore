using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaskEntityFrameworkCore.Model
{
	class TeamMember
	{
		[Required]
		public int Id { get; set; }

		public int? TeamId { get; set; }

		[ForeignKey("TeamId")]
		public ICollection<Team> Team { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public Title Title { get; set; }

	}
		public enum Title
        {
			Developer,
			ScrumMaster,
			ProjectOwner
        }
}
