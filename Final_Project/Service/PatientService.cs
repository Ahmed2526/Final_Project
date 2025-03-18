using DAL.Data;
using DAL.Models;
using Final_Project.Abstractions;
using Final_Project.DTO;
using Final_Project.Errors;
using Final_Project.IService;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Final_Project.Service
{
    public class PatientService : IPatientService
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;

        public PatientService(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }

        public async Task<Result<UserResponse>> Register(UserRegister userCredentials)
        {
            var userExist = await _context.Patients
                .AnyAsync(u => u.Email == userCredentials.Email);

            if (userExist)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.EmailExist });

            var userExist01 = await _context.Patients
                .AnyAsync(u => u.Phone == userCredentials.Phone);

            if (userExist01)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.PhoneExist });

            var user = new Patient()
            {
                Name = userCredentials.Name,
                Email = userCredentials.Email,
                BirthDate = userCredentials.BirthDate,
                Phone = userCredentials.Phone,
                Password = userCredentials.Password
            };

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            var response = new UserResponse()
            {
                Email = user.Email,
                Token = GenerateJwtToken(user)
            };

            return Result<UserResponse>.Success(StatusCodes.Status200OK, response);

        }
        public async Task<Result<UserResponse>> Login(UserLogin userCredentials)
        {
            var User = await _context.Patients.FirstOrDefaultAsync(e => e.Email == userCredentials.Email);

            if (User is null || User.Password != userCredentials.Password)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.InvalidCredentials });

            var response = new UserResponse()
            {
                Email = User.Email,
                Token = GenerateJwtToken(User)
            };

            return Result<UserResponse>.Success(StatusCodes.Status200OK, response);

        }


        public string GenerateJwtToken(Patient user)
        {
            var jwtSettings = _config.GetSection("JwtSettings");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(Convert.ToInt32(jwtSettings["ExpiryDays"])),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
