using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;

namespace jwtWebApi.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
