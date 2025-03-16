using Final_Project.Errors;
using Final_Project.Patterns;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class DoctorRegister
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        [RegularExpression(RegexPatterns.EgyPhonePattern, ErrorMessage = RegexErrors.PhonePattern)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(250)]
        [RegularExpression(RegexPatterns.PasswordPattern, ErrorMessage = RegexErrors.PasswordPattern)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = RegexErrors.PasswordMisMatch)]
        public string ConfirmPassword { get; set; }

        [Required]
        public int SpecialityId { get; set; }
    }
}
