using DAL.Data;
using DAL.Enums;
using DAL.Models;
using Final_Project.DTO;
using Final_Project.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileService _fileService;
        private readonly IMailService _mailService;
        public PatientController(ApplicationDbContext context, IFileService fileService, IMailService mailService)
        {
            _context = context;
            _fileService = fileService;
            _mailService = mailService;
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

        [HttpGet]
        [Route("GetDoctorSchedule")]
        public async Task<IActionResult> GetDoctorSchedule(int Id)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var doc = _context.Doctors
                .Include(e => e.Availabilities)
                .Include(e => e.Clinics)
                .ThenInclude(e => e.Location)
                .ThenInclude(e => e.Governate)
                .Include(e => e.Clinics)
                .ThenInclude(c => c.Location)
                .ThenInclude(l => l.City)
                .FirstOrDefault(e => e.Id == Id);

            if (doc is null)
                return NotFound();

            var data = doc.Availabilities.Select(e => new DocAvailResponse()
            {
                DocId = e.DoctorId,
                ClinicId = e.Clinic.Id,
                Doctor = e.Doctor.FirstName + " " + e.Doctor.LastName,
                Clinic = e.Clinic.Name,
                Governate = e.Clinic.Location.Governate!.Name,
                City = e.Clinic.Location.City!.Name,
                Phone = e.Clinic.Phone,
                Price = e.Clinic.Price,
                Street = e.Clinic.Location.Street,
                Day = e.Day,
                AppointmentStart = e.AppointmentStart,
                AppointmentEnd = e.AppointmentEnd
            }).ToList();

            return Ok(data);
        }

        [HttpPost]
        [Route("BookAppointment")]
        public async Task<IActionResult> Book(AppointmentRequest request)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var checkclinic = await _context.Clinics
                .Where(e => e.DoctorId == request.DoctorId && e.Id == request.ClinicId)
                .Include(e => e.Location)
                .ThenInclude(e => e.Governate)
                .Include(e => e.Location)
                .ThenInclude(e => e.City)
                .FirstOrDefaultAsync();

            if (checkclinic is null)
                return BadRequest("Invalid Request");

            var appointment = new Appointment()
            {
                PatientId = userId,
                DoctorId = request.DoctorId,
                ClinicId = request.ClinicId,
                Day = request.Day,
                AppointmentStart = TimeOnly.Parse(request.AppointmentStart),
                AppointmentEnd = TimeOnly.Parse(request.AppointmentEnd),
                Status = AppointmentStatus.bending,
                Price = checkclinic.Price
            };

            await _context.AddAsync(appointment);
            await _context.SaveChangesAsync();

            //Send Confirmation SMS
            var user = _context.Patients.Find(userId);

            string SMSBody = $"Hello {user!.Name}, your appointment has been successfully booked for {appointment.Day}, {appointment.AppointmentStart} " +
                 $"Location: {checkclinic.Location}. Please arrive 10 minutes early. Thank you!";

            SmsRequest smsRequest = new SmsRequest()
            {
                ToPhoneNumber = "+201027511628",
                Message = SMSBody
            };

           // var status = _mailService.SendConfirmBookingSMS(smsRequest);

            //Send Confirmation Email
            var appInfo = new AppointmentEmailInfo(user.Name, appointment.Day, appointment.AppointmentStart, checkclinic.Location);
            var emailStatus = await _mailService.SendAppointmentConfirmationEmail(user.Email, appInfo);

            return NoContent();
        }

        [HttpGet]
        [Route("GetAppointments")]
        public async Task<IActionResult> GetAppointments()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();


            var today = DateOnly.FromDateTime(DateTime.Today);

            var appointments = await _context.Appointments
                .Where(e => e.PatientId == userId && e.Status != AppointmentStatus.Done && e.Day >= today)
                .Include(e => e.Doctor)
                .Include(e => e.Clinic)
                .ThenInclude(e => e.Location)
                .ThenInclude(e => e.Governate)
                .Include(e => e.Clinic)
                .ThenInclude(e => e.Location)
                .ThenInclude(e => e.City)
                .ToListAsync();

            if (appointments is null || appointments.Count < 1)
                return NotFound();

            var appResponse = appointments.Select(e => new AppointmentResponse()
            {
                Id = e.Id,
                Doctor = e.Doctor.FirstName + " " + e.Doctor.LastName,
                Clinic = e.Clinic.Name,
                Governorate = e.Clinic.Location.Governate!.Name,
                City = e.Clinic.Location.City!.Name,
                Street = e.Clinic.Location.Street,
                Day = e.Day,
                AppointmentStart = e.AppointmentStart,
                AppointmentEnd = e.AppointmentEnd,
                Status = e.Status.ToString()
            }).ToList();

            return Ok(appResponse);
        }


        [HttpDelete]
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

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var user = await _context.Patients.FindAsync(userId);

            if (user is null)
                return NotFound();

            var Uservm = new UserVM()
            {
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
                ProfilePic = user.ProfilePic
            };

            return Ok(Uservm);
        }

        [HttpPost]
        [Route("EditUserProfile")]
        public async Task<IActionResult> EditUserProfile(EditUserVM uservm)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var user = await _context.Patients.FindAsync(userId);
            if (user is null)
                return NotFound();

            var PhoneExist = await _context.Patients
                .Where(e => e.Phone == uservm.Phone && e.Id != userId)
                .FirstOrDefaultAsync();

            if (PhoneExist is not null)
                return BadRequest("Phone Already Registered");


            if (!string.IsNullOrEmpty(uservm.Name))
                user.Name = uservm.Name;


            if (!string.IsNullOrEmpty(uservm.Phone))
                user.Phone = uservm.Phone;


            //Handle Profile Pic
            if (uservm.ProfilePic is not null && uservm.ProfilePic.Length > 0)
            {
                var (status, message, path) = await _fileService.HandleUserProfilePhoto(uservm.ProfilePic, user.ProfilePic);

                if (!status)
                    return BadRequest(message);

                user.ProfilePic = path;
            }

            _context.Update(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}
