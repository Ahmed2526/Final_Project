using Final_Project.IService;

namespace Final_Project.Service
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger _logger;
        public FileService(IWebHostEnvironment env, ILogger<FileService> logger)
        {
            _env = env;
            _logger = logger;
        }

        public async Task<(bool status, string messasge, string path)> HandleDocProfilePhoto(IFormFile file, string? OldPath)
        {
            var permittedExtensions = new[] { ".jpg", ".jpeg", ".png", ".webp" };
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

            if (!permittedExtensions.Contains(extension))
                return (false, "Invalid file type.", null);

            if (OldPath is not null)
            {
                var oldFullPath = Path.Combine(_env.WebRootPath ?? "wwwroot", OldPath.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString()));
                // Delete old file if path is provided and file exists
                if (System.IO.File.Exists(oldFullPath))
                {
                    try
                    {
                        System.IO.File.Delete(oldFullPath);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Failed to delete old photo.");
                    }
                }
            }

            // Generate unique filename
            var fileName = $"{Guid.NewGuid()}{extension}";
            var uploadPath = Path.Combine(_env.WebRootPath ?? "wwwroot", "DocProfilePic");

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            var fullPath = Path.Combine(uploadPath, fileName);
            var relativePath = Path.Combine("/DocProfilePic", fileName).Replace("\\", "/");

            // Save the file
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return (true, "success", relativePath);
        }
    }
}
