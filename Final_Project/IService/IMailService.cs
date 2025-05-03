namespace Final_Project.IService
{
    public interface IMailService
    {
        Task<bool> SendResetEmail(string toEmail, string resetLink);
    }
}
