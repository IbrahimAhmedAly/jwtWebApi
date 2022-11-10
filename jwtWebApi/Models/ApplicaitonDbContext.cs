using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace jwtWebApi.Models
{
    public class ApplicaitonDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options) : base(options)
        {
        }
    }
}
