using Final_Project.Custom_Validations;

namespace Final_Project.DTO
{
    public class AppointmentRequest
    {
        public int DoctorId { get; set; }
        public int ClinicId { get; set; }
        public DateOnly Day { get; set; }

        public string AppointmentStart { get; set; }

        [TimeRangeValidation(nameof(AppointmentStart))]
        public string AppointmentEnd { get; set; }
    }
}
