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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
    new Location { Id = 1, Street = "45 Talaat Harb St.", PostalCode = "10023", GovernateId = 1, CityId = 1 },
    
    new Location { Id = 2, Street = "88 Kasr El Nile St.", PostalCode = "10154", GovernateId = 2, CityId = 9 },
    new Location { Id = 3, Street = "29 Abbas El Akkad St.", PostalCode = "10276", GovernateId = 3, CityId = 12 },
    new Location { Id = 4, Street = "77 El Nasr Rd.", PostalCode = "10322", GovernateId = 4, CityId = 16 },
    new Location { Id = 5, Street = "15 El Merghany St.", PostalCode = "10498", GovernateId = 5, CityId = 19 },
    new Location { Id = 6, Street = "61 Al Haram St.", PostalCode = "10531", GovernateId = 6, CityId = 22 },
    new Location { Id = 7, Street = "94 Faisal St.", PostalCode = "10647", GovernateId = 7, CityId = 25 },
    new Location { Id = 8, Street = "36 October 6th St.", PostalCode = "10782", GovernateId = 8, CityId = 28 },
    new Location { Id = 9, Street = "103 Ahmed Orabi St.", PostalCode = "10859", GovernateId = 9, CityId = 31 },
    new Location { Id = 10, Street = "20 Sudan St.", PostalCode = "10964", GovernateId = 10, CityId = 34 },
    new Location { Id = 11, Street = "11 Shubra St.", PostalCode = "11035", GovernateId = 11, CityId = 37 },
    new Location { Id = 12, Street = "81 Ain Shams St.", PostalCode = "11109", GovernateId = 11, CityId = 38 },
    new Location { Id = 13, Street = "38 Al Moqatam St.", PostalCode = "11243", GovernateId = 12, CityId = 40 },
    new Location { Id = 14, Street = "52 Naguib Mahfouz St.", PostalCode = "11356", GovernateId = 12, CityId = 41 },
    new Location { Id = 15, Street = "66 El Hegaz St.", PostalCode = "11477", GovernateId = 1, CityId = 4 },
    new Location { Id = 16, Street = "91 Salah Salem St.", PostalCode = "11588", GovernateId = 1, CityId = 5 },
    new Location { Id = 17, Street = "27 El Khalifa El Maamoun St.", PostalCode = "11642", GovernateId = 1, CityId = 6 },
    new Location { Id = 18, Street = "74 Al Azhar St.", PostalCode = "11793", GovernateId = 3, CityId = 13 },
    new Location { Id = 19, Street = "59 Mohamed Mahmoud St.", PostalCode = "11834", GovernateId = 3, CityId = 14 },
    new Location { Id = 20, Street = "35 Al Mokattam Corniche", PostalCode = "11921", GovernateId = 4, CityId = 17 },
    new Location { Id = 21, Street = "14 Saad Zaghloul St.", PostalCode = "12015", GovernateId = 4, CityId = 18 },
    new Location { Id = 22, Street = "109 Al Nozha St.", PostalCode = "12126", GovernateId = 5, CityId = 20 },
    new Location { Id = 23, Street = "63 Makram Ebeid St.", PostalCode = "12274", GovernateId = 5, CityId = 21 },
    new Location { Id = 24, Street = "79 El Orouba St.", PostalCode = "12333", GovernateId = 6, CityId = 23 },
    new Location { Id = 25, Street = "32 Cleopatra St.", PostalCode = "12488", GovernateId = 6, CityId = 24 },
    new Location { Id = 26, Street = "48 Al Thawra St.", PostalCode = "12577", GovernateId = 7, CityId = 27 },
    new Location { Id = 27, Street = "17 Al Montazah St.", PostalCode = "12644", GovernateId = 8, CityId = 28 },
    new Location { Id = 28, Street = "70 Ramses St.", PostalCode = "12753", GovernateId = 1, CityId = 2 },
    new Location { Id = 29, Street = "97 Gomhoria St.", PostalCode = "12819", GovernateId = 1, CityId = 3 },
    new Location { Id = 30, Street = "22 Port Said St.", PostalCode = "12902", GovernateId = 2, CityId = 8 }
);

        }

    }
}

