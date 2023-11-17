namespace Medicination.API.Core.Dtos.MedicineDtos
{
	public class GetViewMedicineDto:BaseDto
	{
		public string? MedicineName { get; set; }
		public DateTime ExpirationTime { get; set; }
		public string? Description { get; set; }
		public string? Usage { get; set; }
		public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }

    }
}
