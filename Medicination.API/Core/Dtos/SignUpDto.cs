namespace Medicination.API.Core.Dtos
{
	public class SignUpDto
	{
        public string UserName { get; set; }
        public string  Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
