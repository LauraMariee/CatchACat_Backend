using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Hosting;
using System.Data.Entity;

namespace CatchACat_backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }

    }
}
