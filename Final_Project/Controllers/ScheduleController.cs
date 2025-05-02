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
    [Authorize(Roles = "Doctor")]
    public class ScheduleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route(template: "CreateSchedule")]
        public async Task<IActionResult> Create(ScheduleRequest request)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var checkClinic = await _context.Clinics.FindAsync(request.ClinicId);
            if (checkClinic is null || checkClinic.DoctorId != userId)
                return BadRequest("Invalid Clinic");

            var data = new DoctorAvailability()
            {
                DoctorId = userId,
                Day = request.Day,
                AppointmentStart = TimeOnly.Parse(request.AppointmentStart),
                AppointmentEnd = TimeOnly.Parse(request.AppointmentEnd),
                ClinicId = request.ClinicId
            };

            await _context.AddAsync(data);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route(template: "GetSchedule")]
        public async Task<IActionResult> Get()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var data = await _context.DoctorAvailabilities
                .Where(e => e.DoctorId == userId)
                .Include(e => e.Clinic)
                .ToListAsync();

            if (data is null)
                return NotFound();

            var response = data.Select(e => new ScheduleResponse()
            {
                Id = e.Id,
                Day = e.Day,
                AppointmentStart = e.AppointmentStart,
                AppointmentEnd = e.AppointmentEnd,
                Clinic = e.Clinic.Name
            });

            return Ok(response);
        }

        [HttpPost]
        [Route(template: "EditSchedule/{id}")]
        public async Task<IActionResult> Edit(int id, ScheduleRequest request)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var data = _context.DoctorAvailabilities.Find(id);

            if (data is null)
                return NotFound();

            if (data.DoctorId != userId)
                return BadRequest("Invalid User");

            var checkClinic = await _context.Clinics.FindAsync(request.ClinicId);
            if (checkClinic is null || checkClinic.DoctorId != userId)
                return BadRequest("Invalid Clinic");

            data.Day = request.Day;
            data.AppointmentStart = TimeOnly.Parse(request.AppointmentStart);
            data.AppointmentEnd = TimeOnly.Parse(request.AppointmentEnd);
            data.ClinicId = request.ClinicId;

            _context.Update(data);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        [Route(template: "DeleteSchedule")]
        public async Task<IActionResult> Delete(int id)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var data = _context.DoctorAvailabilities.Find(id);

            if (data is null)
                return NotFound();

            if (data.DoctorId != userId)
                return BadRequest();

            _context.Remove(data);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
