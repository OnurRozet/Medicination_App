using FluentValidation;
using Medicination.API.Core.Dtos;

namespace Medicination.API.Services.Validations
{
	public class SignUpValidator : AbstractValidator<SignUpDto>
	{
		public SignUpValidator()
		{
			RuleFor(x => x.UserName).NotEmpty().NotNull().WithMessage("Kullanıcı Adı Boş Geçilemez");
			RuleFor(x => x.Email).EmailAddress().NotNull().NotEmpty().WithMessage("Email Bölümü Boş Geçilemez");
			RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş geçilemez").MinimumLength(6).WithMessage("Şifre Alanı En Az 6 karakter İçermelidir");
			RuleFor(x => x.ConfirmPassword)
		  .NotEmpty().WithMessage("Şifre onayı boş olamaz.")
		  .Equal(x => x.Password).WithMessage("Şifreler uyuşmuyor.");

		}
	}
}
