using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLearning
{
    public class SimpleSocialNetworkContext : DbContext
    {
        public DbSet<NetworkUser> NetworkUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public SimpleSocialNetworkContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = 127.0.0.1; User Id = postgres; Password = razumovsky123; Database = SimpleNetworkDB;");
        }
    }
}
