
using jwtWebApi.Models.CustomValidation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;
using NuGet.Packaging.Signing;
using System.Xml.Linq;

namespace jwtWebApi.Models
{
    public class RegisterModel
    {
        [Required]
        [ValidateUserName(ErrorMessage = "User Name must be 2 words")]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public IFormFile? Image { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
