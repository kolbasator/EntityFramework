using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class StarringConfiguration : IEntityTypeConfiguration<Starring>
    {
        public void Configure(EntityTypeBuilder<Starring> builder)
        {
            builder.ToTable("Starring").HasKey(k => new { k.ActorId, k.MovieId });
            builder.ToTable("Starring").HasOne(s=>s.Movie).WithMany(m => m.Starring).HasForeignKey(m => m.MovieId);
            builder.ToTable("Starring").HasOne(s=>s.Actor).WithMany(act=>act.Starring).HasForeignKey(act=>act.ActorId);
            builder.ToTable("Starring").HasData(
                new Starring[]
                {
                    new Starring{ActorId=1,MovieId=1},
                    new Starring{ActorId=2,MovieId=1},
                    new Starring{ActorId=3,MovieId=1},
                    new Starring{ActorId=5,MovieId=8},
                    new Starring{ActorId=3,MovieId=9},
                    new Starring{ActorId=4,MovieId=10},
                    new Starring{ActorId=5,MovieId=10},
                    new Starring{ActorId=6,MovieId=6},
                    new Starring{ActorId=8,MovieId=5},
                    new Starring{ActorId=10,MovieId=8}
                });
        }
    }
}
    