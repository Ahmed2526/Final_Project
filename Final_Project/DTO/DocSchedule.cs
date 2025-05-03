using DAL.Enums;
using DAL.Models;

namespace Final_Project.DTO
{
    public class DocSchedule
    {
        public string Patient { get; set; }
        public string Clinic { get; set; }
        public DateOnly Day { get; set; }
        public TimeOnly AppointmentStart { get; set; }
        public TimeOnly AppointmentEnd { get; set; }
    }
}
