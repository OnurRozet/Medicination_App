namespace Medicination.API.Core.Models
{
	public class Member : BaseUserEntity
	{
        public Member()
        {
            Medicines=new HashSet<Medicine>();
        }
        public int UserId { get; set; }
        public User? User { get; set; }
		public ICollection<Medicine>? Medicines { get; set; }
	
	}
}
