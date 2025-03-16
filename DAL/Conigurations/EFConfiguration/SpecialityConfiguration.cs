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
        }
    }
}
