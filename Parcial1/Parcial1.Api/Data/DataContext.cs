using Parcial1.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Parcial1.Api.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Scheduling> Schedulings { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Scheduling>().HasIndex(x => x.ClientName).IsUnique();
        }
    }
}
