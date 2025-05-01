using System.ComponentModel.DataAnnotations;

namespace Final_Project.Custom_Validations
{
    public class ValidDayOfWeekAttribute : ValidationAttribute
    {
        public ValidDayOfWeekAttribute()
        {
            ErrorMessage = "Day must be a valid day of the week (e.g., Monday, Tuesday, etc.).";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var input = value as string;

            if (string.IsNullOrWhiteSpace(input))
                return new ValidationResult(ErrorMessage);

            // Try parsing it using DayOfWeek enum (case-insensitive)
            if (Enum.TryParse(typeof(DayOfWeek), input, true, out _))
                return ValidationResult.Success;

            return new ValidationResult(ErrorMessage);
        }
    }
}
