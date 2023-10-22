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
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _service;
		private readonly IMapper _mapper;

		public CategoriesController(ICategoryService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var entity = await _service.GetAllAsync();
			var categoryDtos = _mapper.Map<List<CategoryDto>>(entity);
			return Ok(CustomResponseDto<List<CategoryDto>>.Succcess(200, categoryDtos));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var entity=await _service.GetById(id);
			var categoryDto=_mapper.Map<CategoryDto>(entity);
			return Ok(CustomResponseDto<CategoryDto>.Succcess(200, categoryDto));
		}

		[HttpPost]
		public async Task<IActionResult> AddCategory(CategoryDto category)
		{
			var addedCategory= await _service.AddAsync(_mapper.Map<Category>(category));
			var categoryDto = _mapper.Map<CategoryDto>(addedCategory);

			return Ok(CustomResponseDto<CategoryDto>.Succcess(201, categoryDto));
		}


		[HttpPut]
		public async Task<IActionResult> UpdateCategory(CategoryDto category)
		{
			 await _service.UpdateAsync(_mapper.Map<Category>(category));
			
			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCategory(int id )
		{
			var entity = await _service.GetById(id);
			await _service.DeleteAsync(entity);

			return Ok(CustomResponseDto<NoContentDto>.Success(204));
		}
	}
}
