namespace DAL.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public double? Rate { get; set; }
        public string? About { get; set; }
        public string? ProfilePic { get; set; }


        public int SpecialityId { get; set; } // Foreign Key
        public Speciality Speciality { get; set; }

        public ICollection<DoctorAvailability> Availabilities { get; set; }
    }
}
