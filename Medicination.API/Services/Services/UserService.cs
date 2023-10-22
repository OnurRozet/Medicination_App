using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;
using Medicination.API.Core.Services;
using Medicination.API.Core.UnitOfWork;

namespace Medicination.API.Services.Services
{
	public class UserService : Service<User>, IUserService
	{
		public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
		}
	}
}
