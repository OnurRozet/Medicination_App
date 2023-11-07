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
	public class UsersController : ControllerBase
	{
		private readonly IUserService _service;
		private readonly IMapper _mapper;
		public UsersController(IUserService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var users = await _service.GetAllAsync();
			var usersDto = _mapper.Map<List<UserDto>>(users);
			return Ok(CustomResponseDto<List<UserDto>>.Succcess(200, usersDto.ToList()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string id)
		{
			var user = await _service.GetById(id);
			var userDto = _mapper.Map<UserDto>(user);
			return Ok(CustomResponseDto<UserDto>.Succcess(200, userDto));
		}

		[HttpPost]
		public async Task<IActionResult> AddUser(UserDto user)
		{
			var addedUser = await _service.AddAsync(_mapper.Map<User>(user));
			var userDto = _mapper.Map<UserDto>(user);
			return Ok(CustomResponseDto<UserDto>.Succcess(201, userDto));
		}


		[HttpPut]
		public async Task<IActionResult> UpdateUser(UserDto user)
		{
			await _service.UpdateAsync(_mapper.Map<User>(user));

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteUser(string id)
		{
			var user = await _service.GetById(id);
			await _service.DeleteAsync(user);

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}
	}
}
