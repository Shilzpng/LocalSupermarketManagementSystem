using Microsoft.EntityFrameworkCore;
using LocalSupermarketManagementSystem.Models;

namespace LocalSupermarketManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
