using DAL.Data;
using DAL.Models;
using Final_Project.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DoctorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DoctorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctor()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var doc = await _context.Doctors.FindAsync(userId);

            var docvm = new DocVM()
            {
                FirstName = doc.FirstName,
                LastName = doc.LastName,
                Email = doc.Email,
                Phone = doc.Phone,
                About = doc.About,
                Rate = doc.Rate
            };

            return Ok(docvm);
        }

        [HttpPost]
        public async Task<IActionResult> EditDoctor(DocVM docvm)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var doc = await _context.Doctors.FindAsync(userId);

            doc.FirstName = docvm.FirstName;
            doc.LastName = docvm.LastName;
            doc.Phone = docvm.Phone;
            doc.About = docvm.About;

            _context.Update(doc);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        [Route("AddClinic")]
        public async Task<IActionResult> CreateClinic(CreateClinic cln)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var location = new Location()
            {
                Street = cln.Street,
                PostalCode = cln.PostalCode,
                CityId = cln.CityId,
                GovernateId = cln.GovernateId,
            };

            await _context.AddAsync(location);
            await _context.SaveChangesAsync();

            var doctor = await _context.Doctors.FindAsync(userId);

            var clinic = new Clinic()
            {
                DoctorId = userId,
                Name = cln.Name,
                SpecialityId = doctor!.SpecialityId,
                Phone = cln.Phone,
                Price = cln.Price,
                LocationId = location.Id
            };

            await _context.AddAsync(clinic);
            await _context.SaveChangesAsync();

            return Created();

        }

        [HttpGet]
        [Route(template: "Clinics")]
        public async Task<IActionResult> GetClinics()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var clinics = await _context.Clinics.Where(e => e.DoctorId == userId)
                .Include(e => e.Location)
                .ThenInclude(e => e.Governate)
                .Include(e => e.Location)
                .ThenInclude(e => e.City)
                .ToListAsync();

            var response = clinics.Select(e => new ClinicResponse()
            {
                Id = e.Id,
                Name = e.Name,
                Phone = e.Phone,
                Price = e.Price,
                Location = e.Location.ToString()
            });

            return Ok(response);
        }


        [HttpGet]
        [Route(template: "GetGovernates")]
        public async Task<IActionResult> GetGovernates()
        {
            var govs = _context.Governates.AsNoTracking().ToList();
            return Ok(govs);
        }

        [HttpGet]
        [Route(template: "GetAreas")]
        public async Task<IActionResult> GetAreas(int govId)
        {
            var Areas = _context.Cities.Where(e => e.GovernateId == govId).ToList();

            var areaResponse = Areas.Select(a => new AreaResponse() { Id = a.Id, Name = a.Name });

            return Ok(areaResponse);
        }


    }
}
