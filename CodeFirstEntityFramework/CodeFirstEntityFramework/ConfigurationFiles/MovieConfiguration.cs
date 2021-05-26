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
                    new Movie{MovieId=1,Title="Terminator",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=2,Title="Ghostbusters",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=3,Title="Taxi Driver",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=4,Title="Frantic",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=5,Title="Ronin",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=6,Title="Leon: the Professional",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=7,Title="Platoon",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=8,Title="Mission Impossible",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=9,Title="The Incredibles",Year=1984,AgeRestriction=12,Price=10},
                    new Movie{MovieId=10,Title="Analyze This",Year=1984,AgeRestriction=12,Price=10}
                }
                );
        }
    }
}
