using System.Globalization;

namespace Medicination.API.Core.Models
{
	public class BaseEntity
	{
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public string FormattedDate
        {
            get
            {
                return CreatedDate.ToString("dd,MM,yyyy");
            }
           
        }
    }
}
