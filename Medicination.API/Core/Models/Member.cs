namespace Medicination.API.Core.Models
{
	public class Member : BaseUserEntity
	{
        public int UserId { get; set; }
        public User? User { get; set; }
		public ICollection<Medicine>? Medicines { get; set; }
	}
}
