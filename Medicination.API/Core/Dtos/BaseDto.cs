namespace Medicination.API.Core.Dtos
{
	public class BaseDto
	{
		public string? Id { get; set; }=Guid.NewGuid().ToString();
		
	}
}
