using Final_Project.Errors;
using Final_Project.Patterns;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class EditClinic
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public decimal Price { get; set; }
        public string? Street { get; set; }
        public int GovernateId { get; set; }
        public int CityId { get; set; }
    }
}
