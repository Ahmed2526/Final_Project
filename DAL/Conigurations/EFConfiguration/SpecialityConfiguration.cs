using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Conigurations.EFConfiguration
{
    class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            // Table Name
            builder.ToTable("Specialities");

            // Primary Key
            builder.HasKey(s => s.Id);

            // Properties Configurations
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(150);

            // Unique Constraint on Name
            builder.HasIndex(s => s.Name).IsUnique();

            #region DataEnglish
            //    builder.HasData(
            //    new Speciality { Id = 1, Name = "Allergist/Immunologist" },
            //    new Speciality { Id = 2, Name = "Anesthesiologist" },
            //    new Speciality { Id = 3, Name = "Cardiologist" },
            //    new Speciality { Id = 4, Name = "Dermatologist" },
            //    new Speciality { Id = 5, Name = "Endocrinologist" },
            //    new Speciality { Id = 6, Name = "Gastroenterologist" },
            //    new Speciality { Id = 7, Name = "General Practitioner" },
            //    new Speciality { Id = 8, Name = "Geriatrician" },
            //    new Speciality { Id = 9, Name = "Hematologist" },
            //    new Speciality { Id = 10, Name = "Infectious Disease Specialist" },
            //    new Speciality { Id = 11, Name = "Internist" },
            //    new Speciality { Id = 12, Name = "Nephrologist" },
            //    new Speciality { Id = 13, Name = "Neurologist" },
            //    new Speciality { Id = 14, Name = "Obstetrician/Gynecologist (OB/GYN)" },
            //    new Speciality { Id = 15, Name = "Oncologist" },
            //    new Speciality { Id = 16, Name = "Ophthalmologist" },
            //    new Speciality { Id = 17, Name = "Orthopedic Surgeon" },
            //    new Speciality { Id = 18, Name = "Otolaryngologist (ENT)" },
            //    new Speciality { Id = 19, Name = "Pathologist" },
            //    new Speciality { Id = 20, Name = "Pediatrician" },
            //    new Speciality { Id = 21, Name = "Plastic Surgeon" },
            //    new Speciality { Id = 22, Name = "Psychiatrist" },
            //    new Speciality { Id = 23, Name = "Pulmonologist" },
            //    new Speciality { Id = 24, Name = "Radiologist" },
            //    new Speciality { Id = 25, Name = "Rheumatologist" },
            //    new Speciality { Id = 26, Name = "Surgeon (General)" },
            //    new Speciality { Id = 27, Name = "Urologist" }
            //);
            #endregion

            builder.HasData(
    new Speciality { Id = 1, Name = "أخصائي حساسية/مناعة" },
    new Speciality { Id = 2, Name = "أخصائي تخدير" },
    new Speciality { Id = 3, Name = "أخصائي قلب" },
    new Speciality { Id = 4, Name = "أخصائي جلدية" },
    new Speciality { Id = 5, Name = "أخصائي غدد صماء" },
    new Speciality { Id = 6, Name = "أخصائي جهاز هضمي" },
    new Speciality { Id = 7, Name = "طبيب عام" },
    new Speciality { Id = 8, Name = "أخصائي طب كبار السن" },
    new Speciality { Id = 9, Name = "أخصائي دم" },
    new Speciality { Id = 10, Name = "أخصائي أمراض معدية" },
    new Speciality { Id = 11, Name = "طبيب باطنية" },
    new Speciality { Id = 12, Name = "أخصائي كلى" },
    new Speciality { Id = 13, Name = "أخصائي أعصاب" },
    new Speciality { Id = 14, Name = "أخصائي نساء وتوليد" },
    new Speciality { Id = 15, Name = "أخصائي أورام" },
    new Speciality { Id = 16, Name = "أخصائي عيون" },
    new Speciality { Id = 17, Name = "جراح عظام" },
    new Speciality { Id = 18, Name = "أخصائي أنف وأذن وحنجرة" },
    new Speciality { Id = 19, Name = "أخصائي أمراض" },
    new Speciality { Id = 20, Name = "أخصائي أطفال" },
    new Speciality { Id = 21, Name = "جراح تجميل" },
    new Speciality { Id = 22, Name = "أخصائي نفسية" },
    new Speciality { Id = 23, Name = "أخصائي صدر" },
    new Speciality { Id = 24, Name = "أخصائي أشعة" },
    new Speciality { Id = 25, Name = "أخصائي روماتيزم" },
    new Speciality { Id = 26, Name = "جراح عام" },
    new Speciality { Id = 27, Name = "أخصائي مسالك بولية" }
);

        }
    }
}
