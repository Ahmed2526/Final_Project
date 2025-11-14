using Final_Project.Errors;
using Final_Project.IService;
using Final_Project.Patterns;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportFactory _reportFactory;

        public ReportsController(IReportFactory reportFactory)
        {
            _reportFactory = reportFactory;
        }

        [HttpGet]
        [Route("Doctors")]
        public async Task<IActionResult> Doctors([FromServices] IDoctorService _doctorService, [FromQuery] string format)
        {
            var data = await _doctorService.DocReportVM();

            if (!Enum.TryParse<ReportFormat>(format, true, out var reportFormat))
                return BadRequest(UserError.InvalidFormat);

            var generator = _reportFactory.GetGenerator(reportFormat);

            var fileBytes = generator.Generate(data);
            var fileName = $"doctor-report-{DateTime.Now:yyyyMMddHHmmss}.{generator.FileExtension}";

            return File(fileBytes, generator.ContentType, fileName);
        }


    }
}
