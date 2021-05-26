using System; 
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Starring> Starring { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public CodeFirstContext()
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new CopyConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new RentalConfiguration());
            modelBuilder.ApplyConfiguration(new ActorConfiguration());
            modelBuilder.ApplyConfiguration(new StarringConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = 127.0.0.1; User Id = postgres; Password = razumovsky123; Database = CodeFirstContextDataBase;");
        }
    }
}
