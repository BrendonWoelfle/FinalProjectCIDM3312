using Microsoft.EntityFrameworkCore;

namespace FinalProjectCIDM3312.Models
{


public class ShirtDbContext : DbContext
    {
        public ShirtDbContext (DbContextOptions<ShirtDbContext> options)
            : base(options)
            {

            }

            public DbSet<Shirt> Shirt {get; set;}
    }

}