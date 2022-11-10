using System.ComponentModel.DataAnnotations;

namespace jwtWebApi.Models.CustomValidation
{
    public class ValidateUserName : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            string[] strings = value.ToString().Split(' ');
            return strings.Length >= 2 && strings.Length <= 4;
        }
    }
}
