using Final_Project.Errors;
using Final_Project.Patterns;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class EditDocVM
    {
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [RegularExpression(RegexPatterns.EgyPhonePattern, ErrorMessage = RegexErrors.PhonePattern)]
        public string? Phone { get; set; }

        [MaxLength(500)]
        public string? About { get; set; }

        public IFormFile? ProfilePic { get; set; }
    }
}
