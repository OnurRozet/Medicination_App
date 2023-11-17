namespace Medicination.API.Core.Dtos.MedicineDtos
{
	public class CreateAndUpdateMedicineDto
	{
		public string? MedicineName { get; set; }
		public DateTime ExpirationTime { get; set; }
		public string? Description { get; set; }
		public string? Usage { get; set; }
		public string? CategoryId { get; set; }
		public List<string>? UserId { get; set; }
		public List<string>? MemberId { get; set; }

	}
}
