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
            builder.ToTable("Copies").HasOne(c=>c.Movie).WithMany(m=>m.Copies).HasForeignKey(m=>m.MovieId);
            builder.ToTable("Copies").HasData(
             new Copy[]
             {
                    new Copy{CopyId=1,Available=false,MovieId=1},
                    new Copy{CopyId=2,Available=false,MovieId=2},
                    new Copy{CopyId=3,Available=false,MovieId=3},
                    new Copy{CopyId=4,Available=false,MovieId=4},
                    new Copy{CopyId=5,Available=false,MovieId=5},
                    new Copy{CopyId=6,Available=false,MovieId=6},
                    new Copy{CopyId=7,Available=false,MovieId=7},
                    new Copy{CopyId=8,Available=false,MovieId=8},
                    new Copy{CopyId=9,Available=false,MovieId=9},
                    new Copy{CopyId=10,Available=false,MovieId=10}
             }
             );
        }
    }
}
