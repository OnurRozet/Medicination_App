using Medicination.API.Core.Enum;

namespace Medicination.API.Core.Dtos.MemberDtos
{
	public class GetViewMemberDto:BaseDto
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public Gender Gender { get; set; }
		public string UserId { get; set; }
		public string? UserName { get; set;}
	}
}
