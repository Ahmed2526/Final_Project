using Final_Project.IService;
using Final_Project.Patterns;

namespace Final_Project.Service
{
    public class ReportFactory : IReportFactory
    {
        private readonly IServiceProvider _provider;

        public ReportFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IReportGenerator GetGenerator(ReportFormat format)
        {
            return format switch
            {
                ReportFormat.pdf => _provider.GetRequiredService<PdfReportGenerator>(),
                ReportFormat.csv => _provider.GetRequiredService<CsvReportGenerator>(),
                _ => throw new ArgumentException("Unsupported format")
            };
        }
    }
}
