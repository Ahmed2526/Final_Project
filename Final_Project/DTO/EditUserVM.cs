using Final_Project.Errors;
using Final_Project.Patterns;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class EditUserVM
    {
        [MaxLength(200)]
        public string? Name { get; set; }

        [RegularExpression(RegexPatterns.EgyPhonePattern, ErrorMessage = RegexErrors.PhonePattern)]
        public string? Phone { get; set; }

        public IFormFile? ProfilePic { get; set; }
    }
}
