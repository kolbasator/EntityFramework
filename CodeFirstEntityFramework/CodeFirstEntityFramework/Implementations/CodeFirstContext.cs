using System;
using System.Collections.Generic;
using System.Text;
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
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = 127.0.0.1; User Id = postgres; Password = razumovsky123; Database = SimpleNetworkDB;");
        }
    }
}
