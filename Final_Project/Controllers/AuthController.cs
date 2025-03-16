using Final_Project.DTO;
using Final_Project.IService;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;

        public AuthController(IPatientService patientService, IDoctorService doctorService)
        {
            _patientService = patientService;
            _doctorService = doctorService;
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


    }
}
