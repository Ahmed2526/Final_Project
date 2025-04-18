namespace DAL.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public int DoctorId { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
}
