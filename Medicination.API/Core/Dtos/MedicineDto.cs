using Medicination.API.Core.Models;

namespace Medicination.API.Core.Dtos
{
	public class MedicineDto : BaseDto
	{
		public string MedicineName { get; set; }
		public string ExpirationTime { get; set; }
		public string? Description { get; set; }
		public string? Usage { get; set; }
		public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<string>? UserId { get; set; }
        public List<string>? MemberId { get; set; }

	}
}
