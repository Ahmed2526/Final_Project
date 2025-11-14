using DAL.Models;

namespace Final_Project.DTO
{
    public class DocReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double? Rate { get; set; }
        public string Speciality { get; set; } 
    }
}
