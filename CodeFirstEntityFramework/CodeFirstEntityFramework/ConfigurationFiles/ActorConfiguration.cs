using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actors").HasKey(c => c.ActorId);
            builder.ToTable("Actors").HasData(
             new Actor[]
             {
                    new Actor{ActorId=1,Firstname="John",Lastname="Johnson",Birthday=new DateTime(2001,11,09)}, 
                    new Actor{ActorId=2,Firstname="Carl",Lastname="Johnson",Birthday=new DateTime(2008,09,08)}, 
                    new Actor{ActorId=3,Firstname="Mark",Lastname="Johnson",Birthday=new DateTime(2024,01,01)}, 
                    new Actor{ActorId=4,Firstname="Khabib",Lastname="Nurmagomedov",Birthday=new DateTime(1998,09,01)}, 
                    new Actor{ActorId=5,Firstname="Paul",Lastname="Chicken",Birthday=new DateTime(1976,10,11)}, 
                    new Actor{ActorId=6,Firstname="Pablo",Lastname="Eskobar",Birthday=new DateTime(1987,08,07)}, 
                    new Actor{ActorId=7,Firstname="Louis",Lastname="Gabriel",Birthday=new DateTime(2011,10,08)}, 
                    new Actor{ActorId=8,Firstname="Genry",Lastname="McChicken",Birthday=new DateTime(1965,01,05)}, 
                    new Actor{ActorId=9,Firstname="Dungeon",Lastname="Master",Birthday=new DateTime(1994,01,04)}, 
                    new Actor{ActorId=10,Firstname="Egor",Lastname="Popov",Birthday=new DateTime(2000,01,02)}, 
             }
             );
        }
    }
}
    