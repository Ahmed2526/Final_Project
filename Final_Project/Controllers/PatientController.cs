using DAL.Data;
using Final_Project.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PatientController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetDoctors")]
        public async Task<IActionResult> GetAllDoctors()
        {
            var docs = await _context.Doctors
                .Include(e => e.Speciality)
                .ToListAsync();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name
            });

            return Ok(docsvm);
        }

        [HttpGet]
        [Route("Doctors/Specialization/{specialityId}")]
        public async Task<IActionResult> GetDoctors(int specialityId)
        {
            var docs = await _context.Doctors.
                Where(e => e.SpecialityId == specialityId)
                .Include(e => e.Speciality)
                .ToListAsync();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name
            });

            return Ok(docsvm);
        }

        [HttpGet]
        [Route("GetDoctor")]
        public async Task<IActionResult> GetDoctor(string docName)
        {
            var docs = await _context.Doctors
            .Where(e => (e.FirstName + " " + e.LastName)
            .Contains(docName))
             .Include(e => e.Speciality)
             .ToListAsync();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name
            });

            return Ok(docsvm);
        }


    }
}
