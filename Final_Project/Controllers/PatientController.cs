using DAL.Data;
using DAL.Enums;
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
    [Authorize(Roles = "User")]
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

            if (docs is null)
                return NotFound();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name,
                ProfilePic = e.ProfilePic
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

            if (docs is null)
                return NotFound();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name,
                ProfilePic = e.ProfilePic
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

            if (docs is null || docs.Count < 1)
                return NotFound();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name,
                ProfilePic = e.ProfilePic
            });

            return Ok(docsvm);
        }

        [HttpGet]
        [Route("GetDoctorsSpecs")]
        public IActionResult GetDoctorsSpecs(DoctorSpecs specs)
        {
            var docs = _context.Clinics
                .Include(e => e.Doctor)
                .ThenInclude(e => e.Speciality)
                .Include(e => e.Location)
                .Where(e => e.SpecialityId == specs.SpecialityId &&
                e.Location.GovernateId == specs.Governorate &&
                e.Location.CityId == specs.Area)
                .Select(e => e.Doctor).ToList();

            var docsvm = docs.Select(e => new DocUserVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                About = e.About,
                Rate = e.Rate,
                Speciality = e.Speciality.Name,
                ProfilePic = e.ProfilePic
            });

            return Ok(docsvm);
        }

        //Enhance
        [HttpPost]
        [Route("BookAppointment")]
        public async Task<IActionResult> Book(AppointmentRequest request)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var checkclinic = await _context.Clinics
                .Where(e => e.DoctorId == request.DoctorId)
                .ToListAsync();

            if (checkclinic is null)
                return BadRequest();

            var appointment = new Appointment()
            {
                PatientId = userId,
                DoctorId = request.DoctorId,
                ClinicId = request.ClinicId,
                Day = request.Day,
                AppointmentStart = TimeOnly.Parse(request.AppointmentStart),
                AppointmentEnd = TimeOnly.Parse(request.AppointmentEnd),
                Status = AppointmentStatus.bending
            };

            await _context.AddAsync(appointment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet]
        [Route("GetAppointments")]
        public async Task<IActionResult> GetAppointments()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var appointments = await _context.Appointments
                .Where(e => e.PatientId == userId && e.Status != AppointmentStatus.Completed)
                .Include(e => e.Doctor)
                .Include(e => e.Clinic)
                .ToListAsync();

            if (appointments is null)
                return NotFound();

            var appResponse = appointments.Select(e => new AppointmentResponse()
            {
                Id = e.Id,
                Doctor = e.Doctor.FirstName + " " + e.Doctor.LastName,
                Clinic = e.Clinic.Name,
                Day = e.Day,
                AppointmentStart = e.AppointmentStart,
                AppointmentEnd = e.AppointmentEnd
            });

            return Ok(appResponse);
        }


        [HttpPost]
        [Route("CancelAppointment")]
        public async Task<IActionResult> DeleteAppointment(int appId)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var appointment = _context.Appointments.Find(appId);

            if (appointment is null)
                return NotFound();

            if (appointment.PatientId != userId)
                return BadRequest();

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            return Ok();
        }


    }
}
