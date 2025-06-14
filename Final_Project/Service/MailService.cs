using Final_Project.DTO;
using Final_Project.IService;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Final_Project.Service
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _config;

        public MailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> SendAppointmentConfirmationEmail(string toEmail, AppointmentEmailInfo appointmentInfo)
        {
            var apiKey = _config["SendGrid:ApiKey"];
            var client = new SendGridClient(apiKey);

            var senderEmail = _config["MedLink:Email"];
            var senderName = _config["MedLink:Name"];

            var from = new EmailAddress(senderEmail, senderName);
            var to = new EmailAddress(toEmail);

            // Load HTML template
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "EmailTemplates", "AppointmentConfirmationEmail.html");
            var htmlTemplate = await File.ReadAllTextAsync(templatePath);

            // Replace placeholders with actual data
            var htmlContent = htmlTemplate
                .Replace("{{UserName}}", appointmentInfo.UserName)
                .Replace("{{AppointmentDay}}", appointmentInfo.AppointmentDay.ToString("dddd, MMMM d, yyyy")) // e.g. Monday, June 17, 2025
                .Replace("{{AppointmentTime}}", appointmentInfo.AppointmentTime.ToString("hh:mm tt"))         // e.g. 09:30 AM
                .Replace("{{ClinicLocation}}", appointmentInfo.ClinicLocation?.ToString() ?? "N/A");

            // Optional: Plain text version (for email clients that don’t support HTML)
            var plainTextContent = $"Hello {appointmentInfo.UserName}, your appointment has been booked for {appointmentInfo.AppointmentDay} at {appointmentInfo.AppointmentTime}. Location: {appointmentInfo.ClinicLocation}. Please arrive 10 minutes early.";

            var msg = MailHelper.CreateSingleEmail(from, to, "Your Appointment is Confirmed", plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            return response.IsSuccessStatusCode;
        }


        public MessageResource.StatusEnum SendConfirmBookingSMS(SmsRequest request)
        {
            var accountSid = _config["Twilio:AccountSid"];
            var authToken = _config["Twilio:AuthToken"];
            var fromPhone = _config["Twilio:FromPhoneNumber"];

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(request.ToPhoneNumber),
                from: new PhoneNumber(fromPhone),
                body: request.Message
            );

            return message.Status;
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

        public async Task<bool> SendResetEmailV02(string toEmail, string resetToken)
        {
            var apiKey = _config["SendGrid:ApiKey"];
            var client = new SendGridClient(apiKey);

            var SenderEmail = _config["MedLink:Email"];
            var SenderName = _config["MedLink:Name"];

            var from = new EmailAddress(SenderEmail, SenderName);
            var to = new EmailAddress(toEmail);

            // Read HTML template from file
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "EmailTemplates", "ResetPasswordV02.html");
            var htmlTemplate = await File.ReadAllTextAsync(templatePath);

            // Inject the reset link
            var htmlContent = htmlTemplate
                .Replace("{{resetCode}}", resetToken);


            var msg = MailHelper.CreateSingleEmail(from, to, "Reset Your Password", null, htmlContent);
            var response = await client.SendEmailAsync(msg);

            return response.IsSuccessStatusCode;

        }
    }
}
