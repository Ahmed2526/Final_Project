using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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


        }
    }
}
