

using System.Collections;

namespace Medicination.API.Core.Models
{
	public class Medicine : BaseEntity
	{
        public Medicine()
        {
            Users = new List<User>();
            Members = new List<Member>();
        }

        public string MedicineName { get; set; }
		public string ExpirationTime { get; set; }
		public string? Description { get; set; }
		public string? Usage { get; set; }
       
        public ICollection<User>? Users { get; set; }

        public ICollection<Member> Members { get; set; }

        public string CategoryId { get; set; }
        public Category? Category { get; set; }


	}
}
