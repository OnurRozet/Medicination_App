using Medicination.API.Core.Dtos;
using Medicination.API.Core.Services;
using Medicination.API.Services.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medicination.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private readonly IAccountService _accountService;

		public AccountsController(IAccountService accountService)
		{
			_accountService = accountService;
		}

		[HttpPost]

		public async Task<IActionResult> SignUp(SignUpDto signUp)
		{
			var result = await _accountService.SignUpAsync(signUp);

			if (!result.Succeeded)
			{
				ModelState.AddModelErrorList(result.Errors.Select(x => x.Description).ToList());
				return BadRequest(ModelState);
			}



			return Ok(signUp);
		}

		[HttpPost]

		public async Task<IActionResult> SignIn(SignInDto signIp)
		{
			var result = await _accountService.SignInAsync(signIp);

			if (!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "Kullanıcı Giriş İşlemi Başarısız");
				return BadRequest(ModelState);
			}

			return Ok(signIp);
		}

		[HttpPost]

		public async Task<IActionResult> ForgetPassword(ForgetPasswordDto forgetPassword)
		{
			var result = await _accountService.ForgetPasswordAsync(forgetPassword);

			if (!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "Bir hata oluştu");
				return BadRequest(ModelState);
			}

			return Ok();
		}

		[HttpPost]

		public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPassword)
		{
			var result=await _accountService.ResetPasswordAsync(resetPassword);

			if (!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "İşlem Başarısız");
			};

			return Ok(result);
		}


	}
}
