using Final_Project.IService;
using System.Text;

namespace Final_Project.Service
{
    public class CsvReportGenerator : IReportGenerator
    {
        public string ContentType => "text/csv";
        public string FileExtension => "csv";

        public byte[] Generate<T>(List<T> data)
        {
            var sb = new StringBuilder();
            var props = typeof(T).GetProperties();

            sb.AppendLine(string.Join(",", props.Select(p => p.Name)));

            foreach (var item in data)
            {
                sb.AppendLine(string.Join(",", props.Select(p => p.GetValue(item))));
            }

            return Encoding.UTF8.GetBytes(sb.ToString());
        }
    }

}
