using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Conigurations.EFConfiguration
{
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
           // Cairo
           new City { Id = 1, Name = "المعادي", GovernateId = 1 },
           new City { Id = 2, Name = "مدينة نصر", GovernateId = 1 },
           new City { Id = 3, Name = "مصر الجديدة", GovernateId = 1 },
           new City { Id = 4, Name = "الزمالك", GovernateId = 1 },
           new City { Id = 5, Name = "الهرم", GovernateId = 1 },
           new City { Id = 6, Name = "العباسية", GovernateId = 1 },
           new City { Id = 7, Name = "الجيزة", GovernateId = 1 },

           // Giza
           new City { Id = 8, Name = "الهرم", GovernateId = 2 },
           new City { Id = 9, Name = "الدقي", GovernateId = 2 },
           new City { Id = 10, Name = "العجوزة", GovernateId = 2 },
           new City { Id = 11, Name = "المهندسين", GovernateId = 2 },

           // Alexandria
           new City { Id = 12, Name = "سموحة", GovernateId = 3 },
           new City { Id = 13, Name = "محطة الرمل", GovernateId = 3 },
           new City { Id = 14, Name = "العصافرة", GovernateId = 3 },
           new City { Id = 15, Name = "السان استيفانو", GovernateId = 3 },

           // Dakahlia
           new City { Id = 16, Name = "المنصورة", GovernateId = 4 },
           new City { Id = 17, Name = "طلخا", GovernateId = 4 },
           new City { Id = 18, Name = "ميت غمر", GovernateId = 4 },

           // Red Sea
           new City { Id = 19, Name = "الغردقة", GovernateId = 5 },
           new City { Id = 20, Name = "رأس غارب", GovernateId = 5 },
           new City { Id = 21, Name = "سفاجا", GovernateId = 5 },

           // Beheira
           new City { Id = 22, Name = "دمنهور", GovernateId = 6 },
           new City { Id = 23, Name = "كفر الدوار", GovernateId = 6 },
           new City { Id = 24, Name = "إيتاي البارود", GovernateId = 6 },

           // Fayoum
           new City { Id = 25, Name = "الفيوم", GovernateId = 7 },
           new City { Id = 26, Name = "سنورس", GovernateId = 7 },
           new City { Id = 27, Name = "طامية", GovernateId = 7 },

           // Gharbia
           new City { Id = 28, Name = "طنطا", GovernateId = 8 },
           new City { Id = 29, Name = "المحلة الكبرى", GovernateId = 8 },
           new City { Id = 30, Name = "كفر الزيات", GovernateId = 8 },

           // Ismailia
           new City { Id = 31, Name = "الإسماعيلية", GovernateId = 9 },
           new City { Id = 32, Name = "فايد", GovernateId = 9 },
           new City { Id = 33, Name = "القنطرة شرق", GovernateId = 9 },

           // Monufia
           new City { Id = 34, Name = "شبين الكوم", GovernateId = 10 },
           new City { Id = 35, Name = "منوف", GovernateId = 10 },
           new City { Id = 36, Name = "أشمون", GovernateId = 10 },

           // Minya
           new City { Id = 37, Name = "المنيا", GovernateId = 11 },
           new City { Id = 38, Name = "ملوي", GovernateId = 11 },
           new City { Id = 39, Name = "أبوقرقاص", GovernateId = 11 },

           // Qalyubia
           new City { Id = 40, Name = "بنها", GovernateId = 12 },
           new City { Id = 41, Name = "قليوب", GovernateId = 12 },
           new City { Id = 42, Name = "شبرا الخيمة", GovernateId = 12 }
       );

        }
    }
}
