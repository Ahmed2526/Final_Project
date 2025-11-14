using Final_Project.Patterns;
using Microsoft.SqlServer.Server;

namespace Final_Project.IService
{
    public interface IReportFactory
    {
        IReportGenerator GetGenerator(ReportFormat format);
    }
}
