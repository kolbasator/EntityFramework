using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstEntityFramework
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees").HasKey(k => new { k.Firstname, k.Lastname });
            builder.ToTable("Employees").HasData(
                new Employee[]
                {
                 new Employee
                    {EmployeeId = 1, Firstname = "John", Lastname = "Smith", Salary = 150.0f, City = "New York"},
                new Employee
                    {EmployeeId = 2, Firstname = "Ben", Lastname = "Johnson", Salary = 250.0f, City = "New York"},
                new Employee
                    {EmployeeId = 3, Firstname = "Louis", Lastname = "Armstrong", Salary = 75.0f, City = "New Orleans"},
                new Employee
                    {EmployeeId = 4, Firstname = "John", Lastname = "Lennon", Salary = 300.0f, City = "London"},
                new Employee
                    {EmployeeId = 5, Firstname = "Peter", Lastname = "Gabriel", Salary = 150.0f, City = "London"}
                }
                );
        }
    }
}
