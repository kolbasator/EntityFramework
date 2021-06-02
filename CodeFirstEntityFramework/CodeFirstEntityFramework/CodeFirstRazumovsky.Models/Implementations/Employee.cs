using System; 
using Microsoft.EntityFrameworkCore; 

namespace CodeFirstEntityFramework
{
    [Keyless]
    public class Employee : IEmployee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public int EmployeeId { get; set; }
        public float Salary { get; set; }
        public Employee()
        {
        }

        public Employee(int employeeId, string firstname, string lastname, float salary, string city)
        {
            EmployeeId = employeeId;
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
            City = city;
        }
        public override string ToString()
        {
            return $"{Firstname},{Lastname},{City},{EmployeeId},{Salary}";
        }
    }
}
