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
    public class DoctorService : IDoctorService
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        public DoctorService(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }

        public async Task<Result<UserResponse>> Register(DoctorRegister docCredentials)
        {
            var userExist = await _context.Doctors
                .AnyAsync(u => u.Email == docCredentials.Email);

            if (userExist)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.EmailExist });

            var userExist01 = await _context.Doctors
                .AnyAsync(u => u.Phone == docCredentials.Phone);

            if (userExist01)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.PhoneExist });

            var specCheck = _context.Specialities.Find(docCredentials.SpecialityId);

            if (specCheck is null)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.InvalidSpeciality });


            var user = new Doctor()
            {
                FirstName = docCredentials.FirstName,
                LastName = docCredentials.LastName,
                Email = docCredentials.Email,
                Phone = docCredentials.Phone,
                Password = docCredentials.Password,
                SpecialityId = docCredentials.SpecialityId
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
        public async Task<Result<UserResponse>> Login(UserLogin docCredentials)
        {
            var User = await _context.Doctors.FirstOrDefaultAsync(e => e.Email == docCredentials.Email);

            if (User is null || User.Password != docCredentials.Password)
                return Result<UserResponse>.Failure(StatusCodes.Status400BadRequest, new[] { UserError.InvalidCredentials });

            var response = new UserResponse()
            {
                Email = User.Email,
                Token = GenerateJwtToken(User)
            };

            return Result<UserResponse>.Success(StatusCodes.Status200OK, response);

        }
        public string GenerateJwtToken(Doctor user)
        {
            var jwtSettings = _config.GetSection("JwtSettings");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(ClaimTypes.Name, user.FirstName+" "+user.LastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
            new Claim(ClaimTypes.Role,"Doctor")
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
