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
    public class ClinicConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.HasData(
    new Clinic { Id = 1, Name = "Heart Care Clinic", Phone = "01010010001", Price = 500, DoctorId = 1, SpecialityId = 1, LocationId = 1 },
    new Clinic { Id = 2, Name = "Kids Health Clinic", Phone = "01010010002", Price = 350, DoctorId = 2, SpecialityId = 2, LocationId = 2 },
    new Clinic { Id = 3, Name = "Surgical Center", Phone = "01010010003", Price = 600, DoctorId = 3, SpecialityId = 3, LocationId = 3 },
    new Clinic { Id = 4, Name = "Skin Wellness Clinic", Phone = "01010010004", Price = 400, DoctorId = 4, SpecialityId = 4, LocationId = 4 },
    new Clinic { Id = 5, Name = "Neuro Center", Phone = "01010010005", Price = 550, DoctorId = 5, SpecialityId = 5, LocationId = 5 },
    new Clinic { Id = 6, Name = "Women's Health Clinic", Phone = "01010010006", Price = 500, DoctorId = 6, SpecialityId = 6, LocationId = 6 },
    new Clinic { Id = 7, Name = "Ortho Move Clinic", Phone = "01010010007", Price = 340, DoctorId = 7, SpecialityId = 7, LocationId = 7 },
    new Clinic { Id = 8, Name = "Chronic Care Clinic", Phone = "01010010008", Price = 300, DoctorId = 8, SpecialityId = 8, LocationId = 8 },
    new Clinic { Id = 9, Name = "Mind Matters Clinic", Phone = "01010010009", Price = 450, DoctorId = 9, SpecialityId = 9, LocationId = 9 },
    new Clinic { Id = 10, Name = "Vision Center", Phone = "01010010010", Price = 500, DoctorId = 10, SpecialityId = 10, LocationId = 10 },

    new Clinic { Id = 11, Name = "ENT Specialists", Phone = "01010010011", Price = 400, DoctorId = 11, SpecialityId = 11, LocationId = 11 },
    new Clinic { Id = 12, Name = "Pathology Lab", Phone = "01010010012", Price = 300, DoctorId = 12, SpecialityId = 12, LocationId = 12 },
    new Clinic { Id = 13, Name = "Endocrine Experts", Phone = "01010010013", Price = 450, DoctorId = 13, SpecialityId = 13, LocationId = 13 },
    new Clinic { Id = 14, Name = "Autoimmune Center", Phone = "01010010014", Price = 470, DoctorId = 14, SpecialityId = 14, LocationId = 14 },
    new Clinic { Id = 15, Name = "Kidney Care Clinic", Phone = "01010010015", Price = 480, DoctorId = 15, SpecialityId = 15, LocationId = 15 },

    new Clinic { Id = 16, Name = "Blood Center", Phone = "01010010016", Price = 500, DoctorId = 16, SpecialityId = 16, LocationId = 16 },
    new Clinic { Id = 17, Name = "Digestive Health Clinic", Phone = "01010010017", Price = 460, DoctorId = 17, SpecialityId = 17, LocationId = 17 },
    new Clinic { Id = 18, Name = "Family Health Clinic", Phone = "01010010018", Price = 350, DoctorId = 18, SpecialityId = 18, LocationId = 18 },
    new Clinic { Id = 19, Name = "Lung & Breathing Clinic", Phone = "01010010019", Price = 430, DoctorId = 19, SpecialityId = 19, LocationId = 19 },
    new Clinic { Id = 20, Name = "Cancer Treatment Center", Phone = "01010010020", Price = 400, DoctorId = 20, SpecialityId = 20, LocationId = 20 },

    new Clinic { Id = 21, Name = "Imaging Center", Phone = "01010010021", Price = 300, DoctorId = 21, SpecialityId = 21, LocationId = 21 },
    new Clinic { Id = 22, Name = "Anesthesia Services", Phone = "01010010022", Price = 200, DoctorId = 22, SpecialityId = 22, LocationId = 22 },
    new Clinic { Id = 23, Name = "Smile Dental Clinic", Phone = "01010010023", Price = 400, DoctorId = 23, SpecialityId = 23, LocationId = 23 },
    new Clinic { Id = 24, Name = "Uro Care Center", Phone = "01010010024", Price = 380, DoctorId = 24, SpecialityId = 24, LocationId = 24 },
    new Clinic { Id = 25, Name = "Beauty & Reconstruction", Phone = "01010010025", Price = 750, DoctorId = 25, SpecialityId = 25, LocationId = 25 },

    new Clinic { Id = 26, Name = "Vascular Solutions", Phone = "01010010026", Price = 350, DoctorId = 26, SpecialityId = 26, LocationId = 26 },
    new Clinic { Id = 27, Name = "Fertility Center", Phone = "01010010027", Price = 450, DoctorId = 27, SpecialityId = 27, LocationId = 27 },
    new Clinic { Id = 28, Name = "Neighborhood GP Clinic", Phone = "01010010028", Price = 300, DoctorId = 28, SpecialityId = 5, LocationId = 28 },
    new Clinic { Id = 29, Name = "Little Stars Pediatrics", Phone = "01010010029", Price = 370, DoctorId = 29, SpecialityId = 6, LocationId = 29 },
    new Clinic { Id = 30, Name = "Critical Care Hub", Phone = "01010010030", Price = 320, DoctorId = 30, SpecialityId = 7, LocationId = 30 }
);

        }
    }
}
