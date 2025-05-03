using DAL.Data;
using DAL.Models;
using Final_Project.DTO;
using Final_Project.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class DoctorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileService _fileService;

        public DoctorsController(ApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctor()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var doc = await _context.Doctors.FindAsync(userId);

            if (doc is null)
                return NotFound();

            var docvm = new DocVM()
            {
                FirstName = doc.FirstName,
                LastName = doc.LastName,
                Email = doc.Email,
                Phone = doc.Phone,
                About = doc.About,
                Rate = doc.Rate,
                ProfilePic = doc.ProfilePic
            };

            return Ok(docvm);
        }

        [HttpPost]
        public async Task<IActionResult> EditDoctorProfile(EditDocVM docvm)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var doc = await _context.Doctors.FindAsync(userId);
            if (doc is null)
                return NotFound();

            var PhoneExist = await _context.Doctors
                .Where(e => e.Phone == docvm.Phone && e.Id != userId)
                .FirstOrDefaultAsync();

            if (PhoneExist is not null)
                return BadRequest("Phone Already Registered");


            if (!string.IsNullOrEmpty(docvm.FirstName))
                doc.FirstName = docvm.FirstName;

            if (!string.IsNullOrEmpty(docvm.LastName))
                doc.LastName = docvm.LastName;

            if (!string.IsNullOrEmpty(docvm.Phone))
                doc.Phone = docvm.Phone;

            if (!string.IsNullOrEmpty(docvm.About))
                doc.About = docvm.About;

            //Handle Profile Pic
            if (docvm.ProfilePic is not null && docvm.ProfilePic.Length > 0)
            {
                var (status, message, path) = await _fileService.HandleDocProfilePhoto(docvm.ProfilePic, doc.ProfilePic);

                if (!status)
                    return BadRequest(message);

                doc.ProfilePic = path;
            }

            _context.Update(doc);
            _context.SaveChanges();

            return Ok();
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
            if (doctor is null)
                return BadRequest("Invalid User");

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


        //Enhance Governorate and city
        [HttpPost]
        [Route("EditClinic")]
        public async Task<IActionResult> EditClinic(EditClinic cln)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var clinic = await _context.Clinics
                .Include(e => e.Location)
                .FirstOrDefaultAsync(e => e.Id == cln.Id);

            if (clinic is null || clinic.DoctorId != userId)
                return BadRequest("Invalid Data");

            if (cln.Name is not null)
                clinic.Name = cln.Name;

            if (cln.Phone is not null)
                clinic.Phone = cln.Phone;

            if (cln.Price > 0)
                clinic.Price = cln.Price;

            if (cln.Street is not null)
                clinic.Location.Street = cln.Street;

            var chkgov = await _context.Governates.FindAsync(cln.GovernateId);
            if (chkgov is not null)
                clinic.Location.GovernateId = cln.GovernateId;

            var chkCity = await _context.Cities
                .Where(e => e.Id == cln.CityId && e.GovernateId == cln.GovernateId)
                .FirstOrDefaultAsync();

            if (chkCity is not null)
                clinic.Location.CityId = cln.CityId;

            _context.Update(clinic);
            await _context.SaveChangesAsync();

            return Ok();
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

            if (clinics is null)
                return NotFound();

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

        [HttpDelete]
        [Route(template: "DeleteClinic")]
        public async Task<IActionResult> DeleteClinic(int id)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var clinic = await _context.Clinics.FindAsync(id);

            if (clinic is null || clinic.DoctorId != userId)
                return BadRequest();

            _context.Clinics.Remove(clinic);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route(template: "GetGovernates")]
        public async Task<IActionResult> GetGovernates()
        {
            var govs = await _context.Governates.AsNoTracking().ToListAsync();
            return Ok(govs);
        }

        [HttpGet]
        [Route(template: "GetAreas")]
        public async Task<IActionResult> GetAreas(int govId)
        {
            var Areas = await _context.Cities.Where(e => e.GovernateId == govId).ToListAsync();
            if (Areas is null)
                return NotFound();

            var areaResponse = Areas.Select(a => new AreaResponse() { Id = a.Id, Name = a.Name });

            return Ok(areaResponse);
        }



    }
}
