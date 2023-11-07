using Microsoft.AspNetCore.Identity;

namespace Medicination.API.Core.Models
{
	public class User : IdentityUser
	{
        public User()
        {
            Medicines=new List<Medicine>();
            Members=new List<Member>();
        }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public ICollection<Medicine>? Medicines { get; set; }
		public ICollection<Member>? Members { get; set; }
     
    }
}
