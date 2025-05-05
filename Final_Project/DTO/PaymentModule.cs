namespace Final_Project.DTO
{
    using System.ComponentModel.DataAnnotations;

    public class PaymentModule
    {
        public int AppointmentId { get; set; }

        [Required]
        [CreditCard(ErrorMessage = "Invalid card number")]
        public string CardNumber { get; set; }

        [Required]
        public string CardHolderName { get; set; }

        [Required]
        [RegularExpression("^(0[1-9]|1[0-2])$", ErrorMessage = "Expiration month must be in MM format")]
        public string ExpirationMonth { get; set; }

        [Required]
        [RegularExpression("^[0-9]{2,4}$", ErrorMessage = "Expiration year must be 2 or 4 digits")]
        public string ExpirationYear { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3,4}$", ErrorMessage = "CVV must be 3 or 4 digits")]
        public string CVV { get; set; }
       
    }


}
