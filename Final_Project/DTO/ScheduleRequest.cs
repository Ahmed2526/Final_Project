using Final_Project.Custom_Validations;

namespace Final_Project.DTO
{
    public class ScheduleRequest
    {
        [ValidDayOfWeek]
        public string Day { get; set; }

        public string AppointmentStart { get; set; }

        [TimeRangeValidation(nameof(AppointmentStart))]
        public string AppointmentEnd { get; set; }
    }
}
