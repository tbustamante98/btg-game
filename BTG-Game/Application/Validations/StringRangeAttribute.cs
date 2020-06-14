using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Application.Validations
{
    public class StringRangeAttribute : ValidationAttribute
    {
        public string[] AllowableValues { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (AllowableValues?.Contains(value?.ToString()) == true)
                return ValidationResult.Success;

            var msg = $"Insira um dos elementos válidos: {string.Join(", ", AllowableValues ?? new string[] { "No allowable values found" })}.";
            return new ValidationResult(msg);
        }
    }
}
