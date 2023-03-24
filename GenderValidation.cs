using System.ComponentModel.DataAnnotations;

namespace ManagementSystemApi
{

    public enum GenderType
    {
        Male,
        Female
    }
    public class GenderValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var gender = value as GenderType?;
            if (gender == null)
            {
                return new ValidationResult("Gender must be specified.");
            }
            else if (gender != GenderType.Male && gender != GenderType.Female)
            {
                return new ValidationResult("Invalid gender specified.");
            }

            return ValidationResult.Success;
        }
    }
}
