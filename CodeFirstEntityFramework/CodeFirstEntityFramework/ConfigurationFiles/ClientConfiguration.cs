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
                    new Client{ClientId=1,Firstname="John",Lastname="Johnson",Birthday=new DateTime(2001,11,09)}, 
                    new Client{ClientId=2,Firstname="David",Lastname="Johnson",Birthday=new DateTime(1999,01,01)}, 
                    new Client{ClientId=3,Firstname="Patrick",Lastname="Johnson",Birthday=new DateTime(1937,08,28)}, 
                    new Client{ClientId=4,Firstname="Rock",Lastname="Lee",Birthday=new DateTime(1978,09,09)}, 
                    new Client{ClientId=5,Firstname="Rick",Lastname="Sanchez",Birthday=new DateTime(2000,02,02)}, 
                    new Client{ClientId=6,Firstname="Leon",Lastname="Gabriel",Birthday=new DateTime(1976,01,08)}, 
                    new Client{ClientId=7,Firstname="Jack",Lastname="Lee",Birthday=new DateTime(1976,01,08)}, 
                    new Client{ClientId=8,Firstname="Paul",Lastname="Sonnen",Birthday=new DateTime(1987,03,18)}, 
                    new Client{ClientId=9,Firstname="Mark",Lastname="McGregor",Birthday=new DateTime(1998,05,08)}, 
                    new Client{ClientId=10,Firstname="Chail",Lastname="Sonnen",Birthday=new DateTime(1989,01,29)} 
             }
             );
        }
    }
}
    