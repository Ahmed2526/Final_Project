using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class SpecialityRequest
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
    }
}
