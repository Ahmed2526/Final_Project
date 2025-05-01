namespace Final_Project.DTO
{
    public class AppointmentResponse
    {
        public int Id { get; set; }
        public string Doctor { get; set; }
        public string Clinic { get; set; }
        public DateOnly Day { get; set; }
        public TimeOnly AppointmentStart { get; set; }
        public TimeOnly AppointmentEnd { get; set; }
    }
}
