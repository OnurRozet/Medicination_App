using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;

namespace Medicination.API.Repository.Repositores
{
	public class MedicineRepository : GenericRepository<Medicine>, IMedicineRepository
	{
		public MedicineRepository(AppDbContext context) : base(context)
		{
		}
	}
}
