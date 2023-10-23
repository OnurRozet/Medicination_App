namespace Medicination.API.Core.Models
{
	public class Category : BaseEntity
	{
        public Category()
        {
            Medicines = new HashSet<Medicine>();
        }
        public string? CategoryName { get; set; }
        public ICollection<Medicine>? Medicines { get; set; }
    }
}
