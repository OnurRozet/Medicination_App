using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace Medicination.API.Core.Dtos
{
	public class IdentityDto:IdentityUser<string>
	{
        public string Id { get; set; }
    }
}
