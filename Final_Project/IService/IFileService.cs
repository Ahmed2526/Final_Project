namespace Final_Project.IService
{
    public interface IFileService
    {
        Task<(bool status, string messasge, string path)> HandleDocProfilePhoto(IFormFile file, string? OldPath);

    }
}
