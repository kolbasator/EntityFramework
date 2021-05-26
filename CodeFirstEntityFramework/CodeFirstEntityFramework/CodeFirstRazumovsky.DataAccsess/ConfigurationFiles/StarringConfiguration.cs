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
            builder.ToTable("Starring").HasOne(s => s.Movie).WithMany(m => m.Starring).HasForeignKey(m => m.MovieId);
            builder.ToTable("Starring").HasOne(s => s.Actor).WithMany(act => act.Starring).HasForeignKey(act => act.ActorId);
            builder.ToTable("Starring").HasData(
                new Starring[]
                {
                          new Starring(3, 1),
                new Starring(4, 1),
                new Starring(5, 1),
                new Starring(6, 1),
                new Starring(7, 1),
                new Starring(8, 1),
                new Starring(1, 3),
                new Starring(9, 3),
                new Starring(10, 3),
                new Starring(11, 2),
                new Starring(12, 2),
                new Starring(13, 2),
                new Starring(14, 4),
                new Starring(15, 4),
                new Starring(16, 4),
                new Starring(17, 4),
                new Starring(18, 5),
                new Starring(19, 5),
                new Starring(20, 5),
                new Starring(21, 6),
                new Starring(22, 6),
                new Starring(14, 7),
                new Starring(23, 7),
                new Starring(14, 8),
                new Starring(24, 8),
                new Starring(25, 8),
                new Starring(23, 9),
                new Starring(27, 9),
                new Starring(23, 10),
                new Starring(28, 10)
        });
        }
    }
}
