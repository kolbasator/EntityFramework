using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEntityFramework
{
    public class Copy : ICopy
    {
        public int CopyId { get; set; }
        public bool Available { get; set; }
        public int MovieId { get; set; } 
        public Movie Movie { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
