namespace DAL.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public int GovernateId { get; set; }
        public Governate? Governate { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }

        public override string ToString()
          => $"{Governate!.Name},{City!.Name}";



    }
}
