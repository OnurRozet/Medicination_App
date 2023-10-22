using AutoMapper;
using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Medicination.API.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicination.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MedicinesController : ControllerBase
	{
		private readonly IMedicineService _service;
		private readonly IMapper _mapper;

		public MedicinesController(IMedicineService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var medicines = await _service.GetAllAsync();
			var medicinesDto = _mapper.Map<List<MedicineDto>>(medicines);
			return Ok(CustomResponseDto<List<MedicineDto>>.Succcess(200, medicinesDto));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var medicine = await _service.GetById(id);
			var medicineDto = _mapper.Map<MedicineDto>(medicine);
			return Ok(CustomResponseDto<MedicineDto>.Succcess(200, medicineDto));
		}

		[HttpPost]
		public async Task<IActionResult> AddCategory(MedicineDto medicineDto)
		{
			var addedMedicine = await _service.AddAsync(_mapper.Map<Medicine>(medicineDto));
			var medicine = _mapper.Map<MedicineDto>(addedMedicine);
			return Ok(CustomResponseDto<MedicineDto>.Succcess(201, medicine));
		}


		[HttpPut]
		public async Task<IActionResult> UpdateCategory(MedicineDto medicineDto)
		{
			await _service.UpdateAsync(_mapper.Map<Medicine>(medicineDto));

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCategory(int id)
		{
			var medicine = await _service.GetById(id);
			await _service.DeleteAsync(medicine);

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}
	}
}
