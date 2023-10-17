using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserAppWebApi.Core.DbContext
{
	public class ApplicationDbContext: IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
		{
		}
	}
}

