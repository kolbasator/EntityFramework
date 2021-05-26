using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals").HasKey(k => new{k.CopyId, k.ClientId});
            builder.ToTable("Rentals").HasOne(r=>r.Copy).WithMany(m => m.Rentals).HasForeignKey(m=>m.CopyId); 
            builder.ToTable("Rentals").HasOne(r=>r.Client).WithMany(c=>c.Rentals).HasForeignKey(c=>c.ClientId);
            builder.ToTable("Rentals").HasData(
            new Rental[]
            {
                    new Rental{CopyId=1,ClientId=1,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=2,ClientId=2,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=3,ClientId=3,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=4,ClientId=4,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=5,ClientId=5,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=6,ClientId=6,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=7,ClientId=7,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=8,ClientId=8,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=9,ClientId=9,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}, 
                    new Rental{CopyId=10,ClientId=10,DateOfRental=DateTime.Now,DateOfReturn=DateTime.Now}
            }
            );
        }
    }
}
    