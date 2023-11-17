using AutoMapper;
using Medicination.API.Core.Dtos;
using Medicination.API.Core.Dtos.MedicineDtos;
using Medicination.API.Core.Models;
using Medicination.API.Core.Repositories;
using Medicination.API.Core.Services;
using Medicination.API.Core.UnitOfWork;
using Microsoft.Identity.Client;

namespace Medicination.API.Services.Services
{
	public class MedicineService /*: Service<Medicine>,*/ : IMedicineService
	{

		//public MedicineService(IGenericRepository<Medicine> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		//{

		//}

		private readonly IMedicineRepository _medicineRepository;

		public MedicineService(IMedicineRepository medicineRepository)
		{
			_medicineRepository = medicineRepository;
		}

		public Task<CreateAndUpdateMedicineDto> AddMedicine(CreateAndUpdateMedicineDto medicine)
		{
			throw new NotImplementedException();
		}

		public Task DeleteMedicine(string id)
		{
			throw new NotImplementedException();
		}

		//public async Task<IQueryable<GetViewMedicineDto>> GetAllMedicine()
		//{ 
		//	var medicine = _medicineRepository.GetAll();

		//	List<GetViewMedicineDto> medicines = new();

		//	foreach (var item in medicine) 
		//	{
		//		var entity = new GetViewMedicineDto
		//		{
		//			Id = item.Id,
		//			CategoryId = item.CategoryId,
		//			CategoryName = item.Category.CategoryName,
		//			Description = item.Description,
		//			ExpirationTime = item.ExpirationTime,
		//			MedicineName = item.MedicineName,
		//			Usage = item.Usage,
		//		};

		//		medicines.Add(entity);
		//	}

		//	return medicines.ToList();


		//}

		public Task<GetViewMedicineDto> GetMedicineById(string id)
		{
			throw new NotImplementedException();
		}

		public Task<CreateAndUpdateMedicineDto> UpdateMedicine(string id, CreateAndUpdateMedicineDto medicine)
		{
			throw new NotImplementedException();
		}
	}
}
