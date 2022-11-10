using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;


namespace jwtWebApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string? Image { get; set; }
    }
}
