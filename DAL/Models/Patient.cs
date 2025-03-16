namespace DAL.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

    }
}
