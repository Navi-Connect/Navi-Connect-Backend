using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NaviBackend.Models
{
    public class NaviContext: IdentityDbContext<User>
    {
        public override DbSet<User> Users { get; set; }
        
        public NaviContext(DbContextOptions<NaviContext> options) : base(options)
        {
        }
    }
}