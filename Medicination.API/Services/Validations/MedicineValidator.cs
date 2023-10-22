using FluentValidation;
using Medicination.API.Core.Dtos;

namespace Medicination.API.Services.Validations
{
	public class MedicineValidator:AbstractValidator<MedicineDto>
	{
        public MedicineValidator()
        {

			RuleFor(x => x.MedicineName).NotNull().NotEmpty().WithMessage("İlaç adı boş olamaz");
			RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Açıklama alanı boş olamaz");
			RuleFor(x => x.Usage).NotNull().NotEmpty().WithMessage("Kullanım koşul alanı boş olamaz");
			RuleFor(x => x.ExpirationTime).NotNull().NotEmpty().WithMessage("Son Kullanma tarihi alanı boş olamaz");

		}
    }
}
