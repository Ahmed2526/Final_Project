using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Conigurations.EFConfiguration
{
    public class DoctorAvailabilityConfiguration : IEntityTypeConfiguration<DoctorAvailability>
    {
        public void Configure(EntityTypeBuilder<DoctorAvailability> builder)
        {
            builder.HasData(
    new DoctorAvailability { Id = 1, Day = "Monday", AppointmentStart = new TimeOnly(9, 0), AppointmentEnd = new TimeOnly(17, 0), DoctorId = 1, ClinicId = 1 },
    new DoctorAvailability { Id = 2, Day = "Tuesday", AppointmentStart = new TimeOnly(10, 0), AppointmentEnd = new TimeOnly(18, 0), DoctorId = 2, ClinicId = 2 },
    new DoctorAvailability { Id = 3, Day = "Wednesday", AppointmentStart = new TimeOnly(8, 30), AppointmentEnd = new TimeOnly(16, 30), DoctorId = 3, ClinicId = 3 },
    new DoctorAvailability { Id = 4, Day = "Thursday", AppointmentStart = new TimeOnly(11, 0), AppointmentEnd = new TimeOnly(19, 0), DoctorId = 4, ClinicId = 4 },
    new DoctorAvailability { Id = 5, Day = "Friday", AppointmentStart = new TimeOnly(9, 0), AppointmentEnd = new TimeOnly(15, 0), DoctorId = 5, ClinicId = 5 },
    new DoctorAvailability { Id = 6, Day = "Saturday", AppointmentStart = new TimeOnly(10, 0), AppointmentEnd = new TimeOnly(17, 0), DoctorId = 6, ClinicId = 6 },
    new DoctorAvailability { Id = 7, Day = "Sunday", AppointmentStart = new TimeOnly(12, 0), AppointmentEnd = new TimeOnly(20, 0), DoctorId = 7, ClinicId = 7 },
    new DoctorAvailability { Id = 8, Day = "Monday", AppointmentStart = new TimeOnly(9, 30), AppointmentEnd = new TimeOnly(17, 30), DoctorId = 8, ClinicId = 8 },
    new DoctorAvailability { Id = 9, Day = "Tuesday", AppointmentStart = new TimeOnly(10, 30), AppointmentEnd = new TimeOnly(18, 30), DoctorId = 9, ClinicId = 9 },
    new DoctorAvailability { Id = 10, Day = "Wednesday", AppointmentStart = new TimeOnly(8, 0), AppointmentEnd = new TimeOnly(14, 0), DoctorId = 10, ClinicId = 10 },

    new DoctorAvailability { Id = 11, Day = "Thursday", AppointmentStart = new TimeOnly(13, 0), AppointmentEnd = new TimeOnly(21, 0), DoctorId = 11, ClinicId = 11 },
    new DoctorAvailability { Id = 12, Day = "Friday", AppointmentStart = new TimeOnly(9, 0), AppointmentEnd = new TimeOnly(13, 0), DoctorId = 12, ClinicId = 12 },
    new DoctorAvailability { Id = 13, Day = "Saturday", AppointmentStart = new TimeOnly(10, 0), AppointmentEnd = new TimeOnly(16, 0), DoctorId = 13, ClinicId = 13 },
    new DoctorAvailability { Id = 14, Day = "Sunday", AppointmentStart = new TimeOnly(11, 0), AppointmentEnd = new TimeOnly(19, 0), DoctorId = 14, ClinicId = 14 },
    new DoctorAvailability { Id = 15, Day = "Monday", AppointmentStart = new TimeOnly(8, 30), AppointmentEnd = new TimeOnly(15, 30), DoctorId = 15, ClinicId = 15 },
    new DoctorAvailability { Id = 16, Day = "Tuesday", AppointmentStart = new TimeOnly(9, 30), AppointmentEnd = new TimeOnly(17, 30), DoctorId = 16, ClinicId = 16 },
    new DoctorAvailability { Id = 17, Day = "Wednesday", AppointmentStart = new TimeOnly(10, 0), AppointmentEnd = new TimeOnly(18, 0), DoctorId = 17, ClinicId = 17 },
    new DoctorAvailability { Id = 18, Day = "Thursday", AppointmentStart = new TimeOnly(12, 0), AppointmentEnd = new TimeOnly(20, 0), DoctorId = 18, ClinicId = 18 },
    new DoctorAvailability { Id = 19, Day = "Friday", AppointmentStart = new TimeOnly(9, 0), AppointmentEnd = new TimeOnly(14, 0), DoctorId = 19, ClinicId = 19 },
    new DoctorAvailability { Id = 20, Day = "Saturday", AppointmentStart = new TimeOnly(11, 0), AppointmentEnd = new TimeOnly(19, 0), DoctorId = 20, ClinicId = 20 },

    new DoctorAvailability { Id = 21, Day = "Sunday", AppointmentStart = new TimeOnly(10, 0), AppointmentEnd = new TimeOnly(16, 0), DoctorId = 21, ClinicId = 21 },
    new DoctorAvailability { Id = 22, Day = "Monday", AppointmentStart = new TimeOnly(8, 0), AppointmentEnd = new TimeOnly(15, 0), DoctorId = 22, ClinicId = 22 },
    new DoctorAvailability { Id = 23, Day = "Tuesday", AppointmentStart = new TimeOnly(9, 0), AppointmentEnd = new TimeOnly(17, 0), DoctorId = 23, ClinicId = 23 },
    new DoctorAvailability { Id = 24, Day = "Wednesday", AppointmentStart = new TimeOnly(13, 0), AppointmentEnd = new TimeOnly(21, 0), DoctorId = 24, ClinicId = 24 },
    new DoctorAvailability { Id = 25, Day = "Thursday", AppointmentStart = new TimeOnly(10, 30), AppointmentEnd = new TimeOnly(18, 30), DoctorId = 25, ClinicId = 25 },
    new DoctorAvailability { Id = 26, Day = "Friday", AppointmentStart = new TimeOnly(8, 30), AppointmentEnd = new TimeOnly(14, 30), DoctorId = 26, ClinicId = 26 },
    new DoctorAvailability { Id = 27, Day = "Saturday", AppointmentStart = new TimeOnly(9, 0), AppointmentEnd = new TimeOnly(17, 0), DoctorId = 27, ClinicId = 27 },
    new DoctorAvailability { Id = 28, Day = "Sunday", AppointmentStart = new TimeOnly(12, 0), AppointmentEnd = new TimeOnly(18, 0), DoctorId = 28, ClinicId = 28 },
    new DoctorAvailability { Id = 29, Day = "Monday", AppointmentStart = new TimeOnly(11, 0), AppointmentEnd = new TimeOnly(19, 0), DoctorId = 29, ClinicId = 29 },
    new DoctorAvailability { Id = 30, Day = "Tuesday", AppointmentStart = new TimeOnly(10, 0), AppointmentEnd = new TimeOnly(16, 0), DoctorId = 30, ClinicId = 30 }
);

        }
    }
}
