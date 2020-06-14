using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<History> History { get; set; }
        public DataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<History>(e => e.Property(h => h.GameDate).HasDefaultValueSql("getdate()"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
