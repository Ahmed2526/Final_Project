using Final_Project.DTO;
using Final_Project.IService;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Final_Project.Service
{
    public class PdfReportGenerator : IReportGenerator
    {
        public string ContentType => "application/pdf";
        public string FileExtension => "pdf";

        public byte[] Generate<T>(List<T> data)
        {
            var properties = typeof(T).GetProperties();

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(40);
                    page.Header().Text($"{typeof(T).Name} Report").FontSize(20).Bold().AlignCenter();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(c =>
                        {
                            foreach (var _ in properties) c.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            foreach (var prop in properties)
                                header.Cell().Element(CellStyle).Text(prop.Name);

                            static IContainer CellStyle(IContainer container) =>
                                container.DefaultTextStyle(x => x.Bold()).Padding(5).Background("#EEE");
                        });

                        foreach (var item in data)
                        {
                            foreach (var prop in properties)
                                table.Cell().Element(c => c.Padding(5)).Text(prop.GetValue(item)?.ToString() ?? "N/A");
                        }
                    });

                    page.Footer().AlignRight().Text($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm}");
                });
            });

            return document.GeneratePdf();
        }
    }


}
