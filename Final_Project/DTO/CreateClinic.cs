namespace Final_Project.DTO
{
    public class CreateClinic
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int GovernateId { get; set; }
        public int CityId { get; set; }

    }
}
