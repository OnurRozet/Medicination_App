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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Medicines ve User arasındaki ilişki
			//modelBuilder.Entity<Medicine>().HasOne(x=>x.User).WithMany(x=>x.Medicines).HasPrincipalKey(x=>x.Id);

			//Medicine ve kategori arasındaki ilişki
			//modelBuilder.Entity<Medicine>().HasOne(x=>x.Category).WithMany(x=>x.Medicines).HasPrincipalKey(x=> x.Id);

			////Medicine ve Member arasındaki ilişki
			//modelBuilder.Entity<Medicine>().HasOne(x => x.Member).WithMany(x => x.Medicines).HasPrincipalKey(x => x.Id);

	//		modelBuilder.Entity<Medicine>()
	//.HasOne(m => m.User)
	//.WithMany(u => u.Medicines)
	//.HasForeignKey(m => m.UserId)
	//.OnDelete(DeleteBehavior.NoAction);
		}

		public DbSet<Medicine> Medicines { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Member> Members { get; set; }
	}
}
