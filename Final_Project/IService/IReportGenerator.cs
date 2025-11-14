using Final_Project.DTO;

namespace Final_Project.IService
{
    public interface IReportGenerator
    {
        string ContentType { get; }
        string FileExtension { get; }
        byte[] Generate<T>(List<T> data);
       
    }
}
