using AutoMapper;
using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Medicination.API.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medicination.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class MembersController : ControllerBase
	{
		private readonly IMemberService _service;
		private readonly IMapper _mapper;

		public MembersController(IMemberService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
	
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var member = await _service.GetAllAsync();
			var memberDto = _mapper.Map<List<MemberDto>>(member);
			return Ok(CustomResponseDto<List<MemberDto>>.Succcess(200, memberDto.ToList()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string id)
		{
			var member = await _service.GetById(id);
			var memberDto= _mapper.Map<MemberDto>(member);
			return Ok(CustomResponseDto<MemberDto>.Succcess(200, memberDto));
		}

		[HttpPost]
		public async Task<IActionResult> AddMember(MemberDto member)
		{

			var addedMember = await _service.AddAsync(_mapper.Map<Member>(member));
			var memberDto = _mapper.Map<MemberDto>(addedMember);
			return Ok(CustomResponseDto<MemberDto>.Succcess(201, memberDto));
		}


		[HttpPut]
		public async Task<IActionResult> UpdateMember(MemberDto member)
		{
			await _service.UpdateAsync(_mapper.Map<Member>(member));

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteMember(string id)
		{
			var member = await _service.GetById(id);
			await _service.DeleteAsync(member);
			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}
	}
}
