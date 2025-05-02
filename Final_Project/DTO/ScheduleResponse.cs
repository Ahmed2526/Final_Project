namespace Final_Project.DTO
{
    public class ScheduleResponse
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeOnly AppointmentStart { get; set; }
        public TimeOnly AppointmentEnd { get; set; }

        public string Clinic { get; set; }
    }
}
