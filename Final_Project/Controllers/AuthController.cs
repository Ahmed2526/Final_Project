using DAL.Data;
using DAL.Models;
using Final_Project.DTO;
using Final_Project.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IMailService _mailService;
        private readonly ApplicationDbContext _context;

        public AuthController(IPatientService patientService, IDoctorService doctorService, ApplicationDbContext context, IMailService mailService)
        {
            _patientService = patientService;
            _doctorService = doctorService;
            _context = context;
            _mailService = mailService;
        }

        [HttpPost]
        [Route("User/SignUp")]
        public async Task<IActionResult> Register([FromBody] UserRegister userCredentials)
        {

            var result = await _patientService.Register(userCredentials);

            if (result.IsSuccess)
                return Ok(result);

            return Problem(string.Join(", ", result.Errors), statusCode: result.StatusCode);

        }

        [HttpPost]
        [Route("User/Login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userCredentials)
        {
            var result = await _patientService.Login(userCredentials);

            if (result.IsSuccess)
                return Ok(result);

            return Problem(string.Join(", ", result.Errors), statusCode: result.StatusCode);

        }

        [HttpPost]
        [Route("User/request-reset")]
        public async Task<IActionResult> RequestPasswordReset(ResetRequestDto dto)
        {
            var user = await _context.Patients.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
                return BadRequest("Email not found.");

            var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            var expiry = DateTime.UtcNow.AddHours(1).ToLocalTime();

            var resetEntry = new PasswordResetToken
            {
                Email = dto.Email,
                Token = token,
                ExpiryDate = expiry
            };

            _context.passwordResetTokens.Add(resetEntry);
            await _context.SaveChangesAsync();

            var resetLink = $"{Request.Scheme}://{Request.Host}/auth/doc/reset-password?token={token}&email={dto.Email}";

            var isSuccess = await _mailService.SendResetEmail(user.Email, resetLink);

            return Ok(isSuccess);
        }

        [HttpPost]
        [Route("User/reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto dto)
        {
            var reset = await _context.passwordResetTokens
                .FirstOrDefaultAsync(r => r.Email == dto.Email && r.Token == dto.Token);

            if (reset == null || reset.ExpiryDate < DateTime.UtcNow.ToLocalTime())
                return BadRequest("Invalid or expired token.");

            var user = await _context.Patients.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
                return NotFound("User not found.");

            user.Password = dto.Password;
            _context.Patients.Update(user);

            // Delete used token
            _context.passwordResetTokens.Remove(reset);
            await _context.SaveChangesAsync();

            return Ok("Password has been reset successfully.");
        }



        [HttpPost]
        [Route("doc/SignUp")]
        public async Task<IActionResult> docRegister([FromBody] DoctorRegister docCredentials)
        {
            var result = await _doctorService.Register(docCredentials);

            if (result.IsSuccess)
                return Ok(result);

            return Problem(string.Join(", ", result.Errors), statusCode: result.StatusCode);

        }

        [HttpPost]
        [Route("doc/Login")]
        public async Task<IActionResult> docLogin([FromBody] UserLogin docCredentials)
        {
            var result = await _doctorService.Login(docCredentials);

            if (result.IsSuccess)
                return Ok(result);

            return Problem(string.Join(", ", result.Errors), statusCode: result.StatusCode);

        }


        [HttpPost]
        [Route("doc/request-reset")]
        public async Task<IActionResult> RequestPasswordResetDoc(ResetRequestDto dto)
        {
            var user = await _context.Doctors.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
                return BadRequest("Email not found.");

            var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            var expiry = DateTime.UtcNow.AddHours(1).ToLocalTime();

            var resetEntry = new PasswordResetToken
            {
                Email = dto.Email,
                Token = token,
                ExpiryDate = expiry
            };

            _context.passwordResetTokens.Add(resetEntry);
            await _context.SaveChangesAsync();

            var resetLink = $"{Request.Scheme}://{Request.Host}/auth/doc/reset-password?token={token}&email={dto.Email}";

            var isSuccess =await _mailService.SendResetEmail(user.Email, resetLink);

            return Ok(isSuccess);
        }


        [HttpPost]
        [Route("doc/reset-password")]
        public async Task<IActionResult> ResetPasswordDoc(ResetPasswordDto dto)
        {
            var reset = await _context.passwordResetTokens
                .FirstOrDefaultAsync(r => r.Email == dto.Email && r.Token == dto.Token);

            if (reset == null || reset.ExpiryDate < DateTime.UtcNow.ToLocalTime())
                return BadRequest("Invalid or expired token.");

            var user = await _context.Doctors.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
                return NotFound("User not found.");

            user.Password = dto.Password;
            _context.Doctors.Update(user);

            // Delete used token
            _context.passwordResetTokens.Remove(reset);
            await _context.SaveChangesAsync();

            return Ok("Password has been reset successfully.");
        }


    }
}
