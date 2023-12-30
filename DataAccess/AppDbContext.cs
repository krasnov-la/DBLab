using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Auto> Autos {get; set;}
        public DbSet<Client> Clients {get; set;}
        public DbSet<Location> Locations {get; set;}
        public DbSet<Receipt> Receipts {get; set;}
        public DbSet<Role> Roles {get; set;}
        public DbSet<Service> Services {get; set;}
        public DbSet<Worker> Workers {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasIndex("Name").IsUnique(true);
            modelBuilder.Entity<Service>().HasIndex("Name").IsUnique(true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connection = File.ReadLines("ConnectionString.txt").First();
            options.UseNpgsql(File.ReadLines("ConnectionString.txt").First());
        }
    }
}