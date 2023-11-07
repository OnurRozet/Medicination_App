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
		private readonly IUserService _userService;
		private readonly IMemberService _memberService;
		private readonly IMapper _mapper;

		public MedicinesController(IMedicineService service, IMapper mapper, IUserService userService, IMemberService memberService)
		{
			_service = service;
			_mapper = mapper;
			_userService = userService;
			_memberService = memberService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var medicines = await _service.GetAllAsync();
			var medicinesDto = _mapper.Map<List<MedicineDto>>(medicines);
			return Ok(CustomResponseDto<List<MedicineDto>>.Succcess(200, medicinesDto));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string id)
		{
			var medicine = await _service.GetById(id);
			var medicineDto = _mapper.Map<MedicineDto>(medicine);
			return Ok(CustomResponseDto<MedicineDto>.Succcess(200, medicineDto));
		}

		[HttpPost]
		public async Task<IActionResult> AddMedicine(MedicineDto medicineDto)
		{

			var medicine = _mapper.Map<Medicine>(medicineDto);

			if (medicineDto.UserId != null)
			{
                foreach (var userId in medicineDto.UserId)
                {
					var user = await _userService.GetById(userId);
					if (user !=null)
					{
						medicine.Users.Add(user);
					}
                }
            }

			if (medicineDto.MemberId != null)
			{
				foreach (var memberId in medicineDto.MemberId)
				{
					var member = await _memberService.GetById(memberId);
					if (member != null)
					{
						medicine.Members.Add(member);
					}
				}
			}



			var addedMedicine = await _service.AddAsync(medicine);
			var addedMedicineDto = _mapper.Map<MedicineDto>(addedMedicine);
			return Ok(CustomResponseDto<MedicineDto>.Succcess(201, addedMedicineDto));
		}



		[HttpPut]
		public async Task<IActionResult> UpdateMedicine(MedicineDto medicineDto)
		{
			await _service.UpdateAsync(_mapper.Map<Medicine>(medicineDto));

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteMedicine(string id)
		{
			var medicine = await _service.GetById(id);
			await _service.DeleteAsync(medicine);

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}
	}
}
