namespace Medicination.API.Core.Dtos
{
	public class SignInDto
	{
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
