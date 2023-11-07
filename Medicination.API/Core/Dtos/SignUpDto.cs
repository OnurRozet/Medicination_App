namespace Medicination.API.Core.Dtos
{
	public class SignUpDto:UserDto
	{
        
        public string? UserName { get; set; }

        public string? Phone { get; set; }
       
        public string? ConfirmPassword { get; set; }
    }
}
