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
        public Copy()
        {
        }

        public Copy(int copyId, int movieId, bool available)
        {
            CopyId = copyId;
            MovieId = movieId;
            Available = available;
        }
        public ICollection<Rental> Rentals { get; set; }
        public override string ToString()
        {
            return $"{CopyId},{Available},{MovieId}";
        }
    }
}
