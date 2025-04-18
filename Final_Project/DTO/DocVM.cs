using Final_Project.Errors;
using Final_Project.Patterns;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class DocVM
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        [RegularExpression(RegexPatterns.EgyPhonePattern, ErrorMessage = RegexErrors.PhonePattern)]
        public string Phone { get; set; }

        [MinLength(3)]
        public string About { get; set; }
        public double? Rate { get; set; }
    }
}
