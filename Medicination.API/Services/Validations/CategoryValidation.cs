using FluentValidation;
using Medicination.API.Core.Dtos;

namespace Medicination.API.Services.Validations
{
	public class CategoryValidation:AbstractValidator<CategoryDto>
	{
        public CategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
