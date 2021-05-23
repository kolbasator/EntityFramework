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
        public DateTime Birthday { get; set; }

    }
}
