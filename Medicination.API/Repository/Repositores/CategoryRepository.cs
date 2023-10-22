using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;

namespace Medicination.API.Repository.Repositores
{
	public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(AppDbContext context) : base(context)
		{
		}
	}
}
