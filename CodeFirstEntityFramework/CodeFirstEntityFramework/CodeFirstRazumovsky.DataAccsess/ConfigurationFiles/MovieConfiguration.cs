using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies").HasKey(m => m.MovieId);
            builder.ToTable("Movies").HasData(
                new Movie[]
                {
                    new Movie(1, "Star Wars Episode IV: A New Hope", 1979, 12, 10f),
                new Movie(2, "Ghostbusters", 1984, 12, 5.5f),
                new Movie(3, "Terminator", 1984, 15, 8.5f),
                new Movie(4, "Taxi Driver", 1976, 17, 5f),
                new Movie(5, "Platoon", 1986, 18, 5f),
                new Movie(6, "Frantic", 1988, 15, 8.5f),
                new Movie(7, "Ronin", 1998, 13, 9.5f),
                new Movie(8, "Analyze This", 1999, 16, 10.5f),
                new Movie(9, "Leon: the Professional", 1994, 16, 8.5f),
                new Movie(10, "Mission Impossible", 1996, 13, 8.5f)
                }
                );
        }
    }
}
