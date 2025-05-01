using System.ComponentModel.DataAnnotations;

namespace Final_Project.Custom_Validations
{
    using System.Globalization;

    public class TimeRangeValidationAttribute : ValidationAttribute
    {
        private readonly string _startPropertyName;

        public TimeRangeValidationAttribute(string startPropertyName)
        {
            _startPropertyName = startPropertyName;
            ErrorMessage = "Appointment end time must be after start time.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var endString = value as string;
            var startProperty = validationContext.ObjectType.GetProperty(_startPropertyName);

            if (startProperty == null)
                return new ValidationResult($"Unknown property: {_startPropertyName}");

            var startString = startProperty.GetValue(validationContext.ObjectInstance) as string;

            if (!TryParseFlexibleTime(startString, out var startTime) ||
                !TryParseFlexibleTime(endString, out var endTime))
            {
                return new ValidationResult("Time must be in 24-hour format (HH:mm) or 12-hour with AM/PM (h:mm tt).");
            }

            if (endTime <= startTime)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success!;
        }

        private bool TryParseFlexibleTime(string input, out TimeOnly result)
        {
            result = default;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            string[] formats =
            {
            "HH:mm",      // 24-hour
            "H:mm",       // 24-hour (single digit)
            "h:mm tt",    // 12-hour with AM/PM
            "hh:mm tt",   // 12-hour padded
        };

            return TimeOnly.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }
    }


}
