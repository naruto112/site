using System;
using Microsoft.EntityFrameworkCore;
using site.Models;

namespace site.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
