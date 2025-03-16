using Final_Project.Errors;
using Final_Project.Patterns;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class UserRegister
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }

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
    }
}
