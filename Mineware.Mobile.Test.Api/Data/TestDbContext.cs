using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mineware.Mobile.Test.Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mineware.Mobile.Test.Api.Data
{
	public class TestDbContext : IdentityDbContext
	{
		public TestDbContext(DbContextOptions<TestDbContext> opt) : base(opt)
		{

		}

		public DbSet<tbl_Student> tbl_Students { get; set; }
	}
}
