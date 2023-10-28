namespace Medicination.API.Core.Services
{
	public interface IEmailService
	{
	   Task SendResetPasswordEmail(string resetPasswordEmailLink, string ToEmail);
		
	}
}
