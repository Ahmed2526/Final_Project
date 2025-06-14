using Final_Project.DTO;
using Final_Project.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialitiesController : ControllerBase
    {
        private readonly ISpecialityService _specialityService;

        public SpecialitiesController(ISpecialityService specialityService)
        {
            _specialityService = specialityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _specialityService.GetAll();

            if (result.IsSuccess)
                return Ok(result);

            return Problem(string.Join(", ", result.Errors), statusCode: result.StatusCode);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SpecialityRequest request)
        {
            var result = await _specialityService.Create(request);

            if (result.IsSuccess)
                return Ok(result);

            return Problem(string.Join(", ", result.Errors), statusCode: result.StatusCode);
        }


    }
}
