﻿//using Medicination.API.Core.Dtos;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Medicination.API.Controllers
//{
//	[Route("api/[controller]")]
//	[ApiController]
//	public class BaseController : ControllerBase
//	{
//		[NonAction]
//		public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
//		{

//			if (response.StatusCode == 204)
//			{
//				return new ObjectResult(null)
//				{
//					StatusCode = response.StatusCode,
//				};
//			}

//			return new ObjectResult(response)
//			{
//				StatusCode = response.StatusCode,
//			};
//		}
//	}
//}
