using Final_Project.IService;
using System.Net.Mail;
using System.Net;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace Final_Project.Service
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _config;

        public MailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> SendResetEmail(string toEmail, string resetLink)
        {
            var apiKey = _config["SendGrid:ApiKey"];
            var client = new SendGridClient(apiKey);

            var SenderEmail = _config["MedLink:Email"];
            var SenderName = _config["MedLink:Name"];

            var from = new EmailAddress(SenderEmail, SenderName);
            var to = new EmailAddress(toEmail);

            // Read HTML template from file
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "EmailTemplates", "ResetPassword.html");
            var htmlTemplate = await File.ReadAllTextAsync(templatePath);

            // Inject the reset link
            var htmlContent = htmlTemplate.Replace("{{resetLink}}", resetLink);

            // Plain text fallback
            var plainTextContent = $"Click the link to reset your password: {resetLink}";

            var msg = MailHelper.CreateSingleEmail(from, to, "Reset Your Password", plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            return response.IsSuccessStatusCode;

        }
    }
}
