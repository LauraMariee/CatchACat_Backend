using Microsoft.EntityFrameworkCore;

namespace CatchACat_backend.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<CatType> CatType { get; set; }
    }
}
