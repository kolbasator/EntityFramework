using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients").HasKey(c => c.ClientId);
            builder.ToTable("Clients").HasData(
             new Client[]
             {
                new Client(1, "Hank", "Hill", Convert.ToDateTime("1954-04-19")),
                new Client(2, "Brian", "Griffin", Convert.ToDateTime("2011-09-11")),
                new Client(3, "Gary", "Goodspeed", Convert.ToDateTime("1989-03-12")),
                new Client(4, "Bob", "Belcher", Convert.ToDateTime("1977-01-23")),
                new Client(5, "Lisa", "Simpson", Convert.ToDateTime("2012-05-09")),
                new Client(6, "Rick", "Sanchez", Convert.ToDateTime("1965-03-17"))
             });
        }
    }
}
