using Microsoft.EntityFrameworkCore;

namespace FinalProjectCIDM3312.Models
{


public class ShoeDbContext : DbContext
    {
        public ShoeDbContext (DbContextOptions<ShoeDbContext> options)
            : base(options)
            {

            }

            public DbSet<Shoe> Shoe {get; set;}
    }

}