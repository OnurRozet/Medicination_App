namespace Medicination.API.Core.Models
{
	public class User : BaseUserEntity
	{
        public User()
        {
            Medicines=new List<Medicine>();
            Members=new List<Member>();
        }
        public string? Email { get; set; }
		public string? Password { get; set; }
		public ICollection<Medicine>? Medicines { get; set; }
		public ICollection<Member>? Members { get; set; }
     
    }
}
