using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DAL.Conigurations.EFConfiguration
{
    class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            // Table Name
            builder.ToTable("Doctors");

            // Primary Key
            builder.HasKey(d => d.Id);

            // Properties Configurations
            builder.Property(d => d.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(d => d.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(d => d.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(d => d.Phone)
                   .IsRequired()
                   .HasMaxLength(25);

            builder.Property(d => d.Password)
                   .IsRequired()
                   .HasMaxLength(250);

            // Unique Constraints
            builder.HasIndex(d => d.Email).IsUnique();
            builder.HasIndex(d => d.Phone).IsUnique();

            builder.HasData(
    new Doctor { Id = 1, FirstName = "Ahmed", LastName = "Samir", Email = "ahmed.samir@example.com", Phone = "01012345678", Password = "hashedpassword1", Rate = 4.6, About = "Dr. Ahmed Samir is a seasoned cardiologist with over 15 years of experience. He is well-known for his expertise in treating complex heart conditions and his dedication to preventative care.", SpecialityId = 1 },
    new Doctor { Id = 2, FirstName = "Nour", LastName = "Hassan", Email = "nour.hassan@example.com", Phone = "01123456789", Password = "hashedpassword2", Rate = 4.7, About = "Dr. Nour Hassan is a passionate pediatrician who excels in creating a friendly and comfortable environment for children while providing high-quality medical care.", SpecialityId = 2 },
    new Doctor { Id = 3, FirstName = "Youssef", LastName = "Mahmoud", Email = "youssef.mahmoud@example.com", Phone = "01234567890", Password = "hashedpassword3", Rate = 4.8, About = "Dr. Youssef Mahmoud is a general surgeon with vast experience in minimally invasive surgical techniques and postoperative care.", SpecialityId = 3 },
    new Doctor { Id = 4, FirstName = "Fatma", LastName = "Amin", Email = "fatma.amin@example.com", Phone = "01587654321", Password = "hashedpassword4", Rate = 4.3, About = "Dr. Fatma Amin is a skilled dermatologist who specializes in treating chronic skin conditions and offers a blend of clinical and aesthetic dermatology.", SpecialityId = 4 },
    new Doctor { Id = 5, FirstName = "Omar", LastName = "Hassan", Email = "omar.hassan@example.com", Phone = "01098765432", Password = "hashedpassword5", Rate = 4.2, About = "Dr. Omar Hassan is a neurologist with deep expertise in treating epilepsy, migraines, and nervous system disorders. He provides comprehensive evaluations and long-term management plans.", SpecialityId = 5 },
    new Doctor { Id = 6, FirstName = "Salma", LastName = "Mostafa", Email = "salma.mostafa@example.com", Phone = "01155667718", Password = "hashedpassword6", Rate = 4.4, About = "Dr. Salma Mostafa is a gynecologist who focuses on women's health and reproductive issues. She is widely respected for her compassionate approach and surgical skill.", SpecialityId = 6 },
    new Doctor { Id = 7, FirstName = "Mohamed", LastName = "Adel", Email = "mohamed.adel@example.com", Phone = "01266778199", Password = "hashedpassword7", Rate = 4.5, About = "Dr. Mohamed Adel is an orthopedic surgeon with a focus on joint replacement and sports injuries. He’s known for helping patients regain mobility with effective treatments.", SpecialityId = 7 },
    new Doctor { Id = 8, FirstName = "Rania", LastName = "Saad", Email = "rania.saad@example.com", Phone = "01599887766", Password = "hashedpassword8", Rate = 4.1, About = "Dr. Rania Saad is an internist providing expert care in chronic conditions such as diabetes, hypertension, and gastrointestinal diseases.", SpecialityId = 8 },
    new Doctor { Id = 9, FirstName = "Hossam", LastName = "Yehia", Email = "hossam.yehia@example.com", Phone = "01022334455", Password = "hashedpassword9", Rate = 4.0, About = "Dr. Hossam Yehia is a psychiatrist with a strong reputation in treating mood and anxiety disorders through both therapy and medication.", SpecialityId = 9 },
    new Doctor { Id = 10, FirstName = "Dina", LastName = "Ibrahim", Email = "dina.ibrahim@example.com", Phone = "01144556677", Password = "hashedpassword10", Rate = 4.9, About = "Dr. Dina Ibrahim is an ophthalmologist skilled in laser eye surgery and glaucoma management. Her detail-oriented care has helped many regain vision.", SpecialityId = 10 },

    new Doctor { Id = 11, FirstName = "Ali", LastName = "Khaled", Email = "ali.khaled@example.com", Phone = "01233445566", Password = "hashedpassword11", Rate = 4.3, About = "Dr. Ali Khaled is an ENT specialist who offers comprehensive care for sinus disorders, hearing loss, and voice disorders.", SpecialityId = 11 },
    new Doctor { Id = 12, FirstName = "Nada", LastName = "Zaki", Email = "nada.zaki@example.com", Phone = "01511223344", Password = "hashedpassword12", Rate = 4.6, About = "Dr. Nada Zaki is a clinical pathologist with a keen interest in hematology and diagnostics. She ensures precise and timely lab results for better diagnosis.", SpecialityId = 12 },
    new Doctor { Id = 13, FirstName = "Karim", LastName = "Osman", Email = "karim.osman@example.com", Phone = "01033445566", Password = "hashedpassword13", Rate = 4.7, About = "Dr. Karim Osman is an endocrinologist specializing in thyroid disorders, diabetes, and metabolic conditions. He combines technology and personal care.", SpecialityId = 13 },
    new Doctor { Id = 14, FirstName = "Layla", LastName = "Nasser", Email = "layla.nasser@example.com", Phone = "01199887766", Password = "hashedpassword14", Rate = 4.8, About = "Dr. Layla Nasser is a rheumatologist with extensive experience in treating autoimmune diseases such as lupus and rheumatoid arthritis.", SpecialityId = 14 },
    new Doctor { Id = 15, FirstName = "Tamer", LastName = "ElSayed", Email = "tamer.elsayed@example.com", Phone = "01277889900", Password = "hashedpassword15", Rate = 4.5, About = "Dr. Tamer ElSayed is a nephrologist who manages patients with kidney failure and provides dialysis care in both acute and chronic settings.", SpecialityId = 15 },

    new Doctor { Id = 16, FirstName = "Maha", LastName = "Amer", Email = "maha.amer@example.com", Phone = "01533445577", Password = "hashedpassword16", Rate = 4.9, About = "Dr. Maha Amer is a hematologist with a strong research background in anemia and leukemia. She provides cutting-edge care in a supportive environment.", SpecialityId = 16 },
    new Doctor { Id = 17, FirstName = "Ehab", LastName = "Hafez", Email = "ehab.hafez@example.com", Phone = "01044556677", Password = "hashedpassword17", Rate = 4.4, About = "Dr. Ehab Hafez is a gastroenterologist known for his advanced colonoscopy techniques and management of IBS and liver disorders.", SpecialityId = 17 },
    new Doctor { Id = 18, FirstName = "Rana", LastName = "Ashraf", Email = "rana.ashraf@example.com", Phone = "01155667788", Password = "hashedpassword18", Rate = 4.3, About = "Dr. Rana Ashraf is a general practitioner with over 12 years of experience in family medicine, preventive care, and health education.", SpecialityId = 18 },
    new Doctor { Id = 19, FirstName = "Mostafa", LastName = "Selim", Email = "mostafa.selim@example.com", Phone = "01266778899", Password = "hashedpassword19", Rate = 4.2, About = "Dr. Mostafa Selim is a pulmonologist who helps patients with asthma, COPD, and chronic bronchitis breathe easier with modern therapies.", SpecialityId = 19 },
    new Doctor { Id = 20, FirstName = "Reem", LastName = "Abdelrahman", Email = "reem.abdelrahman@example.com", Phone = "01577889900", Password = "hashedpassword20", Rate = 4.6, About = "Dr. Reem Abdelrahman is an oncologist providing chemotherapy and personalized cancer care. She builds lasting relationships with her patients.", SpecialityId = 20 },

    new Doctor { Id = 21, FirstName = "Alyaa", LastName = "Mansour", Email = "alyaa.mansour@example.com", Phone = "01099887766", Password = "hashedpassword21", Rate = 4.4, About = "Dr. Alyaa Mansour is a radiologist with exceptional interpretation skills in MRI, CT, and ultrasound. Her quick turnaround time is highly valued.", SpecialityId = 21 },
    new Doctor { Id = 22, FirstName = "Hany", LastName = "Tawfik", Email = "hany.tawfik@example.com", Phone = "01188776655", Password = "hashedpassword22", Rate = 4.7, About = "Dr. Hany Tawfik is an anesthesiologist experienced in surgical and ICU care. His calm presence reassures patients before and during procedures.", SpecialityId = 22 },
    new Doctor { Id = 23, FirstName = "Ghada", LastName = "Ali", Email = "ghada.ali@example.com", Phone = "01233445599", Password = "hashedpassword23", Rate = 4.5, About = "Dr. Ghada Ali is a dental surgeon offering cosmetic and reconstructive dental solutions using the latest techniques and technology.", SpecialityId = 23 },
    new Doctor { Id = 24, FirstName = "Walid", LastName = "Gamal", Email = "walid.gamal@example.com", Phone = "01599887711", Password = "hashedpassword24", Rate = 4.6, About = "Dr. Walid Gamal is a urologist specializing in kidney stone treatment and male reproductive health. He is known for his professionalism and results.", SpecialityId = 24 },
    new Doctor { Id = 25, FirstName = "Nadine", LastName = "Hisham", Email = "nadine.hisham@example.com", Phone = "01033445588", Password = "hashedpassword25", Rate = 4.7, About = "Dr. Nadine Hisham is a plastic surgeon delivering both aesthetic and reconstructive solutions tailored to each patient’s needs and desires.", SpecialityId = 25 },

    new Doctor { Id = 26, FirstName = "Ayman", LastName = "Fathy", Email = "ayman.fathy@example.com", Phone = "01144557766", Password = "hashedpassword26", Rate = 4.8, About = "Dr. Ayman Fathy is a vascular surgeon who treats arterial and venous diseases with minimally invasive procedures.", SpecialityId = 26 },
    new Doctor { Id = 27, FirstName = "Samah", LastName = "Ragab", Email = "samah.ragab@example.com", Phone = "01222334455", Password = "hashedpassword27", Rate = 4.3, About = "Dr. Samah Ragab is a fertility specialist offering IVF, hormonal therapies, and personalized reproductive plans for couples.", SpecialityId = 27 },
    new Doctor { Id = 28, FirstName = "Mahmoud", LastName = "Salem", Email = "mahmoud.salem@example.com", Phone = "01522334455", Password = "hashedpassword28", Rate = 4.6, About = "Dr. Mahmoud Salem is an experienced general practitioner offering whole-person care and long-term patient relationships.", SpecialityId = 5 },
    new Doctor { Id = 29, FirstName = "Marwa", LastName = "Ashour", Email = "marwa.ashour@example.com", Phone = "01066778899", Password = "hashedpassword29", Rate = 4.4, About = "Dr. Marwa Ashour is a dedicated pediatrician who believes in family-focused care and child development education.", SpecialityId = 6 },
    new Doctor { Id = 30, FirstName = "Sherif", LastName = "Tarek", Email = "sherif.tarek@example.com", Phone = "01122334455", Password = "hashedpassword30", Rate = 4.9, About = "Dr. Sherif Tarek is a critical care specialist leading ICU teams with a focus on survival, stabilization, and long-term outcomes.", SpecialityId = 7 }
);





        }
    }
}
