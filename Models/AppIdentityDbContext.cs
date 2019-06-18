using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NETCoreIdentity.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser> 
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> opt) : base(opt)
        { }
            
    }
}