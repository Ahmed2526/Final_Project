using Final_Project.Abstractions;
using Final_Project.DTO;

namespace Final_Project.IService
{
    public interface IDoctorService
    {
        Task<Result<UserResponse>> Login(UserLogin docCredentials);
        Task<Result<UserResponse>> Register(DoctorRegister docCredentials);
    }
}
