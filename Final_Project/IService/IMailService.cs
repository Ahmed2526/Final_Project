namespace Final_Project.IService
{
    public interface IMailService
    {
        Task<bool> SendResetEmail(string toEmail, string resetLink);
        Task<bool> SendResetEmailV02(string toEmail, string resetToken);
    }
}
