using FluentValidation;
using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;
using Medicination.API.Core.Services;
using Medicination.API.Services.Validations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Medicination.API.Services.Services
{
	public class AccountService : IAccountService
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;
		private readonly IEmailService _emailService;
		//private readonly IValidator<SignInDto> _validator;

		public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, IEmailService emailService)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_emailService = emailService;
		}

	
		[HttpPost]
		public async Task<IdentityResult> ForgetPasswordAsync(ForgetPasswordDto entity)
		{
			var user = await _userManager.FindByEmailAsync(entity.Email);

			if (user == null)
			{
				return IdentityResult.Failed(new IdentityError
				{
					Description = "Email Adresi Bulunamadı"
				});
			}

			string passwordReseToken=await _userManager.GeneratePasswordResetTokenAsync(user);

			var resetLink = $"https://localhost:3000/resetpassword?email={Uri.EscapeDataString(user.Email)}&token={Uri.EscapeDataString(passwordReseToken)}";

		  	await _emailService.SendResetPasswordEmail(resetLink, user.Email);

			return IdentityResult.Success;
		}

		public async Task<IdentityResult> ResetPasswordAsync(ResetPasswordDto entity)
		{
			var user = await _userManager.FindByEmailAsync(entity.Email);
			if (user == null)
			{
				return IdentityResult.Failed(new IdentityError
				{
					Description = "Kullanıcı Bulunamadı"
				});
			}

			var token = await _userManager.GeneratePasswordResetTokenAsync(user);

			var result=await _userManager.ResetPasswordAsync(user, token,entity.Password);

			if (!result.Succeeded)
			{
				return IdentityResult.Failed(new IdentityError
				{
					Description = "Şifre Sıfırlama İşlemi Gerçekleştirilemedi"
				});
			}

			return result;
		}

		public async Task<Microsoft.AspNetCore.Identity.SignInResult> SignInAsync(SignInDto signIn)
		{
			var hasUser = await _userManager.FindByEmailAsync(signIn.Email);

			if (hasUser == null)
			{
				return Microsoft.AspNetCore.Identity.SignInResult.Failed;
			}

			var signInResult= await _signInManager.PasswordSignInAsync(hasUser, signIn.Password,signIn.RememberMe,false);

			if (!signInResult.Succeeded)
			{
				return Microsoft.AspNetCore.Identity.SignInResult.Failed;
			}

			return signInResult;
		}

		public async Task<IdentityResult> SignUpAsync(SignUpDto signUp)
		{
			var identityResult = await _userManager.CreateAsync(new User
			{
				Id=signUp.Id,
				Email = signUp.Email,
				UserName = signUp.UserName,
				PhoneNumber = signUp.Phone,
				Name = signUp.Name,
				Surname = signUp.Surname,
			}, signUp.ConfirmPassword);

			if (!identityResult.Succeeded)
			{
				return IdentityResult.Failed(identityResult.Errors.ToArray());
			}

			return identityResult;
		}
	}
}
