using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public interface IEmployee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public int EmployeeId { get; set; }
        public float Salary { get; set; }

    }
}
