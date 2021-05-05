using Microsoft.EntityFrameworkCore;

namespace BroadwayInfoSys.Domain
{
    public class EfContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
             
        }

       
    }
}


