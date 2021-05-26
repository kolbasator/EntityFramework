using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees").HasNoKey();
            builder.ToTable("Employees").HasData(
                new Employee[]
                {
                    new Employee{Firstname="Petr",Lastname="Kolosov",City="New York",Birthday=new DateTime(2001,07,08)}, 
                    new Employee{Firstname="Johnatan",Lastname="Galindo",City="New York",Birthday=new DateTime(1997,11,23)}, 
                    new Employee{Firstname="Carl",Lastname="Gabriel",City="New York",Birthday=new DateTime(2008,09,24)}, 
                    new Employee{Firstname="Louis",Lastname="Lennon",City="New Orleans",Birthday=new DateTime(1991,01,01)}, 
                    new Employee{Firstname="Peter",Lastname="Armstrong",City="New Orleans",Birthday=new DateTime(1956,01,08)}, 
                    new Employee{Firstname="Peter",Lastname="Sanchez",City="New Orleans",Birthday=new DateTime(1997,06,24)}, 
                    new Employee{Firstname="John",Lastname="Johnson",City="London",Birthday=new DateTime(1987,05,14)}, 
                    new Employee{Firstname="Ben",Lastname="Johnson",City="London",Birthday=new DateTime(2021,01,01)}, 
                    new Employee{Firstname="Chail",Lastname="Smith",City="London",Birthday=new DateTime(1999,01,09)}, 
                    new Employee{Firstname="Kirill",Lastname="Chebotarev",City="Moscow",Birthday=new DateTime(2017,11,09)}
                }
                );
        }
    }
}
    