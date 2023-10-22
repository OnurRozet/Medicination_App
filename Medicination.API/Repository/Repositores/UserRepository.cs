using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;

namespace Medicination.API.Repository.Repositores
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public UserRepository(AppDbContext context) : base(context)
		{
		}
	}
}
