using CatachACat_backend.Models.Dbo;
using Microsoft.EntityFrameworkCore;

namespace CatchACat_backend.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        /// <summary>
        /// Only add data to these tables, access data via view
        /// </summary>
        public DbSet<CatTypeDbo> CatType { get; set; }
        public DbSet<CatNameDbo> CatName { get; set; }
        public DbSet<RarityDbo> Rarity { get; set; }
        public DbSet<PlayerDbo> Player { get; set; }
        public DbSet<CaughtCatsDbo> Caught { get; set; }
        public DbSet<CatDbo> Cat { get; set; }

        /// <summary>
        /// Table view which is combined tables - View only 
        /// </summary>
        public DbSet<CompleteCatDbo> CompleteCat { get; set; }
    }
}
