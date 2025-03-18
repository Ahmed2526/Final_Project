using Final_Project.Abstractions;
using Final_Project.DTO;

namespace Final_Project.IService
{
    public interface ISpecialityService
    {
        Task<Result<IEnumerable<SpecialityResponse>>> GetAll();
        Task<Result<SpecialityResponse>> Create(SpecialityRequest request);

    }
}
