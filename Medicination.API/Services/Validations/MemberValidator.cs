using FluentValidation;
using Medicination.API.Core.Dtos;

namespace Medicination.API.Services.Validations
{
	public class MemberValidator:AbstractValidator<MemberDto>
	{
        public MemberValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().NotNull().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x=>x.Surname).NotEmpty().NotNull().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x=>x.Gender).NotEmpty().WithMessage("{PropertyName} boş olamaz").IsInEnum().WithMessage("Geçerli bir cinsiyet seçin."); ;
		}
    }
}
