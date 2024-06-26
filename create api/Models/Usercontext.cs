using Microsoft.EntityFrameworkCore;

namespace create_api.Models
{
    public class Usercontext : DbContext
    {
        public Usercontext(DbContextOptions options) : base(options)
        {
           
            
        }
        public DbSet<Users> Users { get; set; }
    }
}
