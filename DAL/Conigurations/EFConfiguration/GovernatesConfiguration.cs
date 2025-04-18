using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Conigurations.EFConfiguration
{
    class GovernatesConfiguration : IEntityTypeConfiguration<Governate>
    {
        public void Configure(EntityTypeBuilder<Governate> builder)
        {
            builder.HasData(
            new Governate { Id = 1, Name = "القاهرة" },
            new Governate { Id = 2, Name = "الجيزة" },
            new Governate { Id = 3, Name = "الأسكندرية" },
            new Governate { Id = 4, Name = "الدقهلية" },
            new Governate { Id = 5, Name = "البحر الأحمر" },
            new Governate { Id = 6, Name = "البحيرة" },
            new Governate { Id = 7, Name = "الفيوم" },
            new Governate { Id = 8, Name = "الغربية" },
            new Governate { Id = 9, Name = "الإسماعلية" },
            new Governate { Id = 10, Name = "المنوفية" },
            new Governate { Id = 11, Name = "المنيا" },
            new Governate { Id = 12, Name = "القليوبية" },
            new Governate { Id = 13, Name = "الوادي الجديد" },
            new Governate { Id = 14, Name = "السويس" },
            new Governate { Id = 15, Name = "اسوان" },
            new Governate { Id = 16, Name = "اسيوط" },
            new Governate { Id = 17, Name = "بني سويف" },
            new Governate { Id = 18, Name = "بورسعيد" },
            new Governate { Id = 19, Name = "دمياط" },
            new Governate { Id = 20, Name = "الشرقية" },
            new Governate { Id = 21, Name = "جنوب سيناء" },
            new Governate { Id = 22, Name = "كفر الشيخ" },
            new Governate { Id = 23, Name = "مطروح" },
            new Governate { Id = 24, Name = "الأقصر" },
            new Governate { Id = 25, Name = "قنا" },
            new Governate { Id = 26, Name = "شمال سيناء" },
            new Governate { Id = 27, Name = "سوهاج" }
        );
        }
    }
}
