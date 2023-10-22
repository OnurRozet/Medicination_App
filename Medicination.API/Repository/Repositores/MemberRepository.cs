using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;

namespace Medicination.API.Repository.Repositores
{
	public class MemberRepository : GenericRepository<Member>, IMemberRepository
	{
		public MemberRepository(AppDbContext context) : base(context)
		{
		}
	}
}
