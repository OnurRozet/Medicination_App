using Medicination.API.Core.Enum;

namespace Medicination.API.Core.Models
{
	public class BaseUserEntity
	{
		public string Id { get; set; }
		public string? Name { get; set; }
        public string? Surname { get; set; }
		public Gender Gender { get; set; }
	}
}
