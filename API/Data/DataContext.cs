using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alojamiento>().Property<int>("Id").HasColumnName("Identifier");
        }

        public DbSet<Alojamiento> Alojamiento { get; set; }
    }
}