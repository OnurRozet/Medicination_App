using Medicination.API.Core.Models;

namespace Medicination.API.Core.Dtos
{
	public class MedicineDto : BaseDto
	{
		public string? MedicineName { get; set; }
		public DateTime ExpirationTime { get; set; }
		public string? Description { get; set; }
		public string? Usage { get; set; }
		public int CategoryId { get; set; }
        public List<int>? UserId { get; set; }
        public List<int>? MemberId { get; set; }

	}
}
