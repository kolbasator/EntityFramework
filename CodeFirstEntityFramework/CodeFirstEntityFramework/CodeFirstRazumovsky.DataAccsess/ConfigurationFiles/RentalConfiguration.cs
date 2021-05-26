using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals").HasKey(k => new { k.CopyId, k.ClientId });
            builder.ToTable("Rentals").HasOne(r => r.Copy).WithMany(m => m.Rentals).HasForeignKey(m => m.CopyId);
            builder.ToTable("Rentals").HasOne(r => r.Client).WithMany(c => c.Rentals).HasForeignKey(c => c.ClientId);
            builder.ToTable("Rentals").HasData(
            new Rental[]
            {
                  new Rental(1, 1, Convert.ToDateTime("2005-07-04"), Convert.ToDateTime("2005-07-05")),
                new Rental(1, 6, Convert.ToDateTime("2005-07-19"), Convert.ToDateTime("2005-07-22")),
                new Rental(2, 3, Convert.ToDateTime("2005-07-24"), Convert.ToDateTime("2005-07-25")),
                new Rental(2, 5, Convert.ToDateTime("2005-07-26"), Convert.ToDateTime("2005-07-27")),
                new Rental(2, 7, Convert.ToDateTime("2005-07-29"), Convert.ToDateTime("2005-07-30")),
                new Rental(3, 12, Convert.ToDateTime("2005-07-10"), Convert.ToDateTime("2005-07-13")),
                new Rental(3, 20, Convert.ToDateTime("2005-07-16"), Convert.ToDateTime("2005-07-17")),
                new Rental(3, 3, Convert.ToDateTime("2005-07-22"), Convert.ToDateTime("2005-07-23")),
                new Rental(3, 7, Convert.ToDateTime("2005-07-24"), Convert.ToDateTime("2005-07-25")),
                new Rental(4, 13, Convert.ToDateTime("2005-07-01"), Convert.ToDateTime("2005-07-05")),
                new Rental(5, 11, Convert.ToDateTime("2005-07-10"), Convert.ToDateTime("2005-07-13")),
                new Rental(6, 1, Convert.ToDateTime("2005-07-06"), Convert.ToDateTime("2005-07-07")),
                new Rental(6, 7, Convert.ToDateTime("2005-07-29"), Convert.ToDateTime("2005-07-30")),
                new Rental(6, 19, Convert.ToDateTime("2005-07-29"), Convert.ToDateTime("2005-07-30"))
        }
            );
        }
    }
}
