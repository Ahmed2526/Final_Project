using Final_Project.DTO;
using Twilio.Rest.Api.V2010.Account;

namespace Final_Project.IService
{
    public interface IMailService
    {
        Task<bool> SendResetEmail(string toEmail, string resetLink);
        Task<bool> SendResetEmailV02(string toEmail, string resetToken);
        Task<bool> SendAppointmentConfirmationEmail(string toEmail, AppointmentEmailInfo appointmentInfo);
        MessageResource.StatusEnum SendConfirmBookingSMS(SmsRequest request);
    }
}
