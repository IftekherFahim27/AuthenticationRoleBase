using AuthenticationRoleBase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationRoleBase.Services
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LeadEntity> LeadEntities { get; set; }

        public DbSet<Category>Categories { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
