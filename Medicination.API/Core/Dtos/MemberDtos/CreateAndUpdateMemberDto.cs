using Medicination.API.Core.Enum;

namespace Medicination.API.Core.Dtos.MemberDtos
{
	public class CreateAndUpdateMemberDto
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public Gender Gender { get; set; }
		public string UserId { get; set; }
	}
}
