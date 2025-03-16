using Final_Project.Abstractions;
using Final_Project.DTO;

namespace Final_Project.IService
{
    public interface IPatientService
    {
        Task<Result<UserResponse>> Login(UserLogin userCredentials);
        Task<Result<UserResponse>> Register(UserRegister userCredentials);
    }
}
