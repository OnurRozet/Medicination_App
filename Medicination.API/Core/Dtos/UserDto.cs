using Medicination.API.Core.Enum;

namespace Medicination.API.Core.Dtos
{
	public class UserDto:BaseDto
	{
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
		public string? Password { get; set; }
        public Gender Gender { get; set; }
    }
}
