using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Conigurations.EFConfiguration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            // Table Name
            builder.ToTable("Patients");

            // Primary Key
            builder.HasKey(p => p.Id);

            // Properties Configurations
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.BirthDate)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Phone)
                   .IsRequired()
                   .HasMaxLength(25);

            builder.Property(p => p.Password)
                   .IsRequired()
                   .HasMaxLength(250);

            // Unique Constraints
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.Phone).IsUnique();
        }


    }

}
