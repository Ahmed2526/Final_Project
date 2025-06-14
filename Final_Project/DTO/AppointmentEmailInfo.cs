using DAL.Models;

namespace Final_Project.DTO
{
    public class AppointmentEmailInfo
    {
        public string UserName { get; set; }
        public DateOnly AppointmentDay { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public Location ClinicLocation { get; set; }

        public AppointmentEmailInfo(string userName, DateOnly day, TimeOnly time, Location location)
        {
            UserName = userName;
            AppointmentDay = day;
            AppointmentTime = time;
            ClinicLocation = location;
        }
    }
}
