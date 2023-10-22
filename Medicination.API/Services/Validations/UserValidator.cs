using FluentValidation;
using Medicination.API.Core.Dtos;

namespace Medicination.API.Services.Validations
{
	public class UserValidator : AbstractValidator<UserDto>
	{
		public UserValidator()
		{
			RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("{ProprtyName} boş olamaz");
			RuleFor(x => x.Surname).NotNull().WithMessage("{PropertyName} boş olamaz");
			RuleFor(user => user.Password)
		  .NotEmpty().WithMessage("Şifre alanı boş olamaz.")
		  .MinimumLength(6).WithMessage("Şifre en az 6 karakter içermelidir.");

			RuleFor(user => user.Email)
				.NotEmpty().WithMessage("E-posta alanı boş olamaz.")
				.EmailAddress().WithMessage("Geçerli bir e-posta adresi girin.");

			RuleFor(user => user.Gender)
				.NotEmpty().WithMessage("Cinsiyet alanı boş olamaz.")
				.IsInEnum().WithMessage("Geçerli bir cinsiyet seçin.");

		}
	}
}
