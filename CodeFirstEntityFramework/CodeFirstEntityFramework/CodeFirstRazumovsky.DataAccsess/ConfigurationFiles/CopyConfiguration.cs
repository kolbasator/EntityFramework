using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class CopyConfiguration : IEntityTypeConfiguration<Copy>
    {
        public void Configure(EntityTypeBuilder<Copy> builder)
        {
            builder.ToTable("Copies").HasKey(c => c.CopyId);
            builder.ToTable("Copies").HasOne(c => c.Movie).WithMany(m => m.Copies).HasForeignKey(m => m.MovieId);
            builder.ToTable("Copies").HasData(
             new Copy[]
             {
                new Copy(1, 1, true),
                new Copy(2, 1, false),
                new Copy(3, 2, true),
                new Copy(4, 3, true),
                new Copy(5, 3, false),
                new Copy(6, 3, true),
                new Copy(7, 4, true),
                new Copy(8, 5, false),
                new Copy(9, 6, true),
                new Copy(10, 6, false),
                new Copy(11, 6, true),
                new Copy(12, 7, true),
                new Copy(13, 7, true),
                new Copy(14, 8, false),
                new Copy(15, 9, true),
                new Copy(16, 10, true),
                new Copy(17, 10, false),
                new Copy(18, 10, true),
                new Copy(19, 10, true),
                new Copy(20, 10, true)
        });
        }

    }

}
