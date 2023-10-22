using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;
using Medicination.API.Core.Services;
using Medicination.API.Core.UnitOfWork;

namespace Medicination.API.Services.Services
{
	public class MemberService : Service<Member>, IMemberService
	{
		public MemberService(IGenericRepository<Member> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
		}
	}
}
