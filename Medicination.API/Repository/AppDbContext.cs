using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Microsoft.EntityFrameworkCore;


namespace Medicination.API.Repository
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Medicine> Medicines { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Member> Members { get; set; }
	}
}
