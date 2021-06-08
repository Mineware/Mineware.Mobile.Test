using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mineware.Mobile.Test.Api.Data.Models
{
	public class tbl_Student
	{
		[Key]
		public int StudentID { get; set; }
		[MaxLength(20)]
		public string Name { get; set; }
		[MaxLength(40)]
		public string LastName { get; set; }
		[MaxLength(13)]
		public string IDNumber { get; set; }
		[MaxLength(15)]
		public string ContactNumberHome { get; set; }
		[MaxLength(15)]
		public string ContactNumberMobile { get; set; }
	}
}
