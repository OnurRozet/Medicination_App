using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Medicination.API.Repository
{
	public class AppDbContext : IdentityDbContext<User,IdentityRole,string>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Medicine> Medicines { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Member> Members { get; set; }
	}
}
