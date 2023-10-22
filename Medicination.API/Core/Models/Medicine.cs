using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Medicination.API.Core.Models
{
	public class Medicine : BaseEntity
	{
		public string? MedicineName { get; set; }
		public DateTime ExpirationTime { get; set; }
		public string? Description { get; set; }
		public string? Usage { get; set; }

		public ICollection<User>? User { get; set; }
		public ICollection<Member>? Member { get; set; }
		public int CategoryId { get; set; }
		public Category? Category { get; set; }


	}
}
