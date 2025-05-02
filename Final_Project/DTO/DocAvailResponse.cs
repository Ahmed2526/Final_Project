using DAL.Models;

namespace Final_Project.DTO
{
    public class DocAvailResponse
    {
        public int DocId { get; set; }
        public int ClinicId { get; set; }
        public string Doctor { get; set; }
        public string Clinic { get; set; }
        public string Street { get; set; }
        public string Governate { get; set; }
        public string City { get; set; }
        public decimal Price { get; set; }
        public string Phone { get; set; }

        public string Day { get; set; }
        public TimeOnly AppointmentStart { get; set; }
        public TimeOnly AppointmentEnd { get; set; }

       

    }
}
