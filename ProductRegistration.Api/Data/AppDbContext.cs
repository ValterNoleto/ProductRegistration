using Microsoft.EntityFrameworkCore;
using ProductRegistration.Api.Models;

namespace ProductRegistration.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt)
            : base(opt) { }

        public DbSet<Product> Products { get; set; }
    }
}
