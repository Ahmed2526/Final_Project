namespace DAL.Models
{
    public class DoctorAvailability
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeOnly AppointmentStart { get; set; }
        public TimeOnly AppointmentEnd { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

    }
}
