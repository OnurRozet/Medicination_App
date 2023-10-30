using Medicination.API.Core.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Medicination.API.Core.Services
{
	public interface IAccountService
	{
		Task<IdentityResult> SignUpAsync(SignUpDto signUp);

		Task<SignInResult> SignInAsync(SignInDto signIn);

		Task<IdentityResult> ForgetPasswordAsync(ForgetPasswordDto forgetPassword);

		Task<IdentityResult> ResetPasswordAsync(ResetPasswordDto resetPassword);
	}
}
