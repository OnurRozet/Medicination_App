using Medicination.API.Core.Enum;

namespace Medicination.API.Core.Dtos
{
	public class MemberDto : BaseDto
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public Gender Gender { get; set; }
        public string UserId { get; set; }
        
    }
}
