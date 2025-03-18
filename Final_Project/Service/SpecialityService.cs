using DAL.Data;
using DAL.Models;
using Final_Project.Abstractions;
using Final_Project.DTO;
using Final_Project.Errors;
using Final_Project.IService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Service
{
    public class SpecialityService : ISpecialityService
    {
        private readonly ApplicationDbContext _context;

        public SpecialityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Result<IEnumerable<SpecialityResponse>>> GetAll()
        {
            var specialities = await _context.Specialities
                .AsNoTracking().ToListAsync();

            if (specialities is null || specialities.Count == 0)
                return Result<IEnumerable<SpecialityResponse>>.Failure(StatusCodes.Status404NotFound, new[] { SpecialityError.NoSpeciality });

            var result = specialities.Select(s => new SpecialityResponse
            {
                Id = s.Id,
                Name = s.Name
            });

            return Result<IEnumerable<SpecialityResponse>>.Success(StatusCodes.Status200OK, result);

        }
        public async Task<Result<SpecialityResponse>> Create(SpecialityRequest request)
        {
            var specialityExist = await _context.Specialities.AnyAsync(s => s.Name == request.Name);

            if (specialityExist)
                return Result<SpecialityResponse>.Failure(StatusCodes.Status400BadRequest, new[] { SpecialityError.SpecialityExist });

            var speciality = new Speciality()
            {
                Name = request.Name
            };

            await _context.AddAsync(speciality);
            await _context.SaveChangesAsync();


            var response = new SpecialityResponse()
            {
                Id = speciality.Id,
                Name = speciality.Name
            };

            return Result<SpecialityResponse>.Success(StatusCodes.Status200OK, response);

        }
    }
}
