namespace DAL.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GovernateId { get; set; }
        public Governate? Governate { get; set; }

    }
}
