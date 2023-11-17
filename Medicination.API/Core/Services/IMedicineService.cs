
using Medicination.API.Core.Dtos;
using Medicination.API.Core.Dtos.MedicineDtos;
using Medicination.API.Core.Models;

namespace Medicination.API.Core.Services
{
	public interface IMedicineService/*:IService<Medicine>*/
	{

		Task<IQueryable<GetViewMedicineDto>> GetAllMedicine();

		Task<GetViewMedicineDto> GetMedicineById(string id);

		Task<CreateAndUpdateMedicineDto> AddMedicine(CreateAndUpdateMedicineDto medicine);

		Task<CreateAndUpdateMedicineDto> UpdateMedicine(string id,CreateAndUpdateMedicineDto medicine);

		Task DeleteMedicine(string id);
		
	}
}
