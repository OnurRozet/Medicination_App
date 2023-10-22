using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;
using Medicination.API.Core.Services;
using Medicination.API.Core.UnitOfWork;

namespace Medicination.API.Services.Services
{
	public class CategoryService : Service<Category>, ICategoryService
	{
		public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
		}
	}
}
