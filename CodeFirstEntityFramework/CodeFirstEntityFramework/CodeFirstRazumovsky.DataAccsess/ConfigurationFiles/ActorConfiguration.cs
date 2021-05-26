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
                new Actor(1, "Arnold", "Schwarzenegger", Convert.ToDateTime("1947-07-30")),
                new Actor(2, "Anthony", "Daniels", Convert.ToDateTime("1946-02-21")),
                new Actor(3, "Harrison", "Ford", Convert.ToDateTime("1942-07-13")),
                new Actor(4, "Carrie", "Fisher", Convert.ToDateTime("1956-10-21")),
                new Actor(5, "Alec", "Guiness", Convert.ToDateTime("1914-04-02")),
                new Actor(6, "Peter", "Cushing", Convert.ToDateTime("1913-05-26")),
                new Actor(7, "David", "Prowse", Convert.ToDateTime("1944-05-19")),
                new Actor(8, "Peter", "Mayhew", Convert.ToDateTime("1935-07-01")),
                new Actor(9, "Michael", "Biehn", Convert.ToDateTime("1956-07-31")),
                new Actor(10, "Linda", "Hamilton", Convert.ToDateTime("1956-09-26")),
                new Actor(11, "Bill", "Murray", Convert.ToDateTime("1950-09-21")),
                new Actor(12, "Dan", "Aykroyd", Convert.ToDateTime("1952-07-01")),
                new Actor(13, "Sigourney", "Weaver", Convert.ToDateTime("1949-10-08")),
                new Actor(14, "Robert", "De Niro", Convert.ToDateTime("1943-08-17")),
                new Actor(15, "Jodie", "Foster", Convert.ToDateTime("1962-11-19")),
                new Actor(16, "Harvey", "Keitel", Convert.ToDateTime("1939-05-13")),
                new Actor(17, "Cybill", "Shepherd", Convert.ToDateTime("1950-02-18")),
                new Actor(18, "Tom", "Berenger", Convert.ToDateTime("1949-05-31")),
                new Actor(19, "Willem", "Dafoe", Convert.ToDateTime("1955-07-22")),
                new Actor(20, "Charlie", "Sheen", Convert.ToDateTime("1965-09-03")),
                new Actor(21, "Harrison", "Ford", Convert.ToDateTime("1942-07-13")),
                new Actor(22, "Emmanuelle", "Seigner", Convert.ToDateTime("1966-06-22")),
                new Actor(23, "Jean", "Reno", Convert.ToDateTime("1948-07-30")),
                new Actor(24, "Billy", "Crystal", Convert.ToDateTime("1948-03-14")),
                new Actor(25, "Lisa", "Kudrow", Convert.ToDateTime("1963-07-30")),
                new Actor(26, "Gary", "Oldman", Convert.ToDateTime("1958-03-21")),
                new Actor(27, "Natalie", "Portman", Convert.ToDateTime("1981-06-09")),
                new Actor(28, "Tom", "Cruise", Convert.ToDateTime("1962-07-03")));
        }
    }
}

