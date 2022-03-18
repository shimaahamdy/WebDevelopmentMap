using System.ComponentModel.DataAnnotations;

namespace Day5_Demo_42.Models
{
    public class MinAge : ValidationAttribute
    {
        int Value;
        public MinAge(int num)
        {
            Value = num;
        }
        protected override ValidationResult IsValid(object obj, ValidationContext validationContext)
        {
            if (obj != null)
            {
                if (obj is int)
                {
                    int suppliedValue = (int)obj;
                    if (suppliedValue < Value)
                    {
                        //user validation error
                        return new ValidationResult("Minimum value for age should be " + Value);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}