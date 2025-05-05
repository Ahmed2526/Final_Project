using DAL.Data;
using DAL.Enums;
using DAL.Models;
using Final_Project.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPay(int Appointmentid)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var appoit = await _context.Appointments
                .Where(e => e.Id == Appointmentid && e.PatientId == userId && e.Status == AppointmentStatus.bending)
                .FirstOrDefaultAsync();

            if (appoit is null)
                return BadRequest("Invalid Data");

            var appresponse = new GetPay()
            {
                Id = appoit.Id,
                Status = appoit.Status.ToString(),
                Price = appoit.Price
            };

            return Ok(appresponse);
        }

        [HttpPost]
        public async Task<IActionResult> Pay(PaymentModule paymentModule)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
                return Unauthorized();

            var appoit = await _context.Appointments
                .Where(e => e.Id == paymentModule.AppointmentId && e.PatientId == userId && e.Status == AppointmentStatus.bending)
                .FirstOrDefaultAsync();

            if (appoit is null)
                return BadRequest("Invalid Data");

            var payment = new Payment()
            {
                PatientId = userId,
                PaymentMethod = PaymentMethod.OnlineCard,
                Amount = (decimal)appoit.Price!,
                Date = DateTime.UtcNow.ToLocalTime(),
                PaymentKey = Guid.NewGuid().ToString()
            };

            appoit.Status = AppointmentStatus.Paid;

            await _context.AddAsync(payment);
            _context.Update(appoit);
            await _context.SaveChangesAsync();

            return Ok();
        }


    }
}
