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
        public DateTime Birthday { get; set; }
    }
}
